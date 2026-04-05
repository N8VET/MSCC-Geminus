@echo off
echo INITIALIZATION CONFIGURATION FILE INSTALL.
echo INSTALLATION WILL OVERWRITE ANY EXISTING CONFIGURATION FILES. 
echo:
echo:
echo:
echo:
echo THE ANSWER IS CASE SENSITIVE AND MUST BE COMPLETE (Yes / No).
echo DO YOU WANT TO INSTALL THE INITIALIZATION CONFIGURATION FILES?
set /p Input=Enter Yes or No:
if /I "%Input%"=="Yes" (goto yes) else (goto no)
:yes
cd init-files
del /Q %localappdata%\mscc-GEMINUS\*
xcopy * %localappdata%\mscc-GEMINUS\ /s /e /h /Y
pause
goto:EOF
:no
echo INSTALLATION NOT RUN
pause
