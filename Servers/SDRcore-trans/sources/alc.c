#include "extern.h"
#include "commands.h"
#define _CRT_SECURE_NO_WARNINGS 1

extern sp_float G_peak;
extern alc_state alcstate;

#define AVERAGE_LIMIT 200
#define N_DECIMAL_POINTS_PRECISION (1000) // n = 3. Three decimal points.
#define ALC_CALIBRATION_FACTOR (1.5f)


uint8_t G_Run_ALC = FALSE;

//float VU_average_buffer[AVERAGE_LIMIT] = {0};
float ALC_average_buffer[AVERAGE_LIMIT] = {0.0f};
uint16_t Result_aveage_buffer[AVERAGE_LIMIT] = { 0 };
uint16_t Average_limit = AVERAGE_LIMIT;


float ALC_average(uint8_t reset, float ALC_Value) {
    float ALC_average_result = 0;
    int i = 0;
    uint16_t average_count = 0;
    float ALC_average = 0;

    if (reset == FALSE) {
        ALC_average_buffer[0] = ALC_Value;
        for (average_count = 0; average_count < Average_limit; average_count++) {
            ALC_average = ALC_average + ALC_average_buffer[average_count];
        }
        ALC_average_result = ALC_average / (float) average_count;
        for (i = (Average_limit - 1); i > 0; i--) {
            ALC_average_buffer[i] = ALC_average_buffer[(i - 1)];
        }
    } else {
        print_time();
        fprintf(G_fp_logfile, "[%d] ALC_average RESET\n", line_number);
        for (average_count = 0; average_count < Average_limit; average_count++) {
            ALC_average_buffer[average_count] = ALC_Value;
            ALC_average = ALC_average + ALC_average_buffer[average_count];
        }
        ALC_average_result = ALC_average / (float) average_count;
    }
    ALC_average = 0.0f;
    return ALC_average_result;
}

uint16_t Result_average(uint8_t reset, int16_t ALC_Value) {
    uint32_t ALC_average_result = 0;
    int i = 0;
    uint32_t average_count = 0;
    uint32_t ALC_average = 0;

    if (reset == FALSE) {
        Result_aveage_buffer[0] = ALC_Value;
        for (average_count = 0; average_count < Average_limit; average_count++) {
            ALC_average = ALC_average + Result_aveage_buffer[average_count];
        }
        ALC_average_result = ALC_average / average_count;
        for (i = (Average_limit - 1); i > 0; i--) {
            Result_aveage_buffer[i] = Result_aveage_buffer[(i - 1)];
        }
    }
    else {
        print_time();
        fprintf(G_fp_logfile, "[%d] Result_average RESET\n", line_number);
        memset(Result_aveage_buffer, 0, Average_limit);
        /*for (average_count = 0; average_count < AVERAGE_LIMIT; average_count++) {
            ALC_average_buffer[average_count] = ALC_Value;
            ALC_average = ALC_average + ALC_average_buffer[average_count];
        }
        ALC_average_result = ALC_average / (float)average_count;
        */
    }
    ALC_average = 0;
    return ALC_average_result;
}
void *ALC_Meter_thread(void *t) {
    char send_buf[20];
    unsigned long sleep_time = 10;
    uint8_t new_session = TRUE;
    float alc = 0.0f;
    uint16_t alc_i = 0;
    uint16_t previous_alc_i = 0;
    uint16_t result_average = 0;
    float alc_average_value = 0;
    uint16_t previous_average_limit = 0;

    Sleep(1); //Let the subsystem initialize before processing ALC
    print_time();
    fprintf(G_fp_logfile, "[%d] ALC_Meter_thread. Thread STARTED.\n", line_number++);
    while (G_all_threads_run) {
        if (G_tx_mode == 1 && G_Run_ALC == TRUE) {
            if (new_session == TRUE) {
                switch (G_audio_mode) {
                case DIGITAL_AUDIO:
                    Average_limit = AVERAGE_LIMIT;
                    break;
                case OPERATOR_AUDIO:
                    Average_limit = 100;
                }
                mystate.overdriven = 0;
                alc = 1.0000f;
                alc_average_value = ALC_average(new_session, alc);
                result_average = Result_average(new_session, 0);
                send_buf[0] = CMD_SET_ALC;
                alc_i = 0;
                memcpy(&send_buf[1], &alc_i, 2);
                if (sendto(ms_sdr_s, (char *) &send_buf, 5, 0, (struct sockaddr *) &si_ms_sdr, slen) == SOCKET_ERROR) {
                    print_time();
                    fprintf(G_fp_logfile, "[%d] ALC_Meter_thread. sentto FAILED. error code : %s\n",
                            line_number++, strerror(errno));
                }
                new_session = FALSE;
            } else {
                if (G_ALC_gain < 1.000f) {
                    alc = G_ALC_gain;
                } else {
                    alc = 1.0000f;
                }
                alc_average_value = ALC_average(new_session, alc);
            }
            alc_average_value = 1.0000f - alc_average_value;
            alc_average_value = alc_average_value * ALC_CALIBRATION_FACTOR;
            alc_i = ((uint16_t) (alc_average_value * N_DECIMAL_POINTS_PRECISION) % N_DECIMAL_POINTS_PRECISION);
            result_average = Result_average(new_session, alc_i);
            if (previous_alc_i != result_average) {
                if (G_Do_ALC == TRUE) {
                        send_buf[0] = CMD_SET_ALC;
                        memcpy(&send_buf[1], &result_average, 2);
                        if (sendto(ms_sdr_s, (char*)&send_buf, 5, 0, (struct sockaddr*)&si_ms_sdr, slen) == SOCKET_ERROR) {
                            print_time();
                            fprintf(G_fp_logfile, "[%d] ALC_Meter_thread. sentto FAILED. error code : %s\n", line_number++, strerror(errno));
                        }
                }
                previous_alc_i = result_average;
            }
        }
        if (new_session == FALSE && G_tx_mode == FALSE) {  //Send a zero ALC value when G_tx_mode as been set back to FALSE
            mystate.overdriven = 0;
            new_session = TRUE;
            alc_i = 0;
            send_buf[0] = CMD_SET_ALC;
            memcpy(&send_buf[1], &alc_i, 2);
            if (sendto(ms_sdr_s, (char*)&send_buf, 5, 0, (struct sockaddr*)&si_ms_sdr, slen) == SOCKET_ERROR) {
                print_time();
                fprintf(G_fp_logfile, "[%d] ALC_Meter_thread. sentto FAILED. error code : %s\n",
                    line_number++, strerror(errno));
            }
        }
        Sleep(sleep_time);
    }
    print_time();
    fprintf(G_fp_logfile, "[%d] ALC_Meter_thread. Normal Exit\n", line_number++);
    pthread_exit(0);
    return (NULL);
}