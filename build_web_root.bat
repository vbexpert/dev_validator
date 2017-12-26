rem wipa all:
del /f /s /q web_root\*.*
rmdir /s /q web_root
if not exist "web_root" mkdir "web_root"

rem create filders:
if not exist "web_root\uploads" mkdir "web_root\uploads"
if not exist "web_root\tasks" mkdir "web_root\tasks"
echo 0>"web_root\uploads\0"

rem delpoy validator.exe:
copy "dev_validator_C\bin\Debug\validator.exe" "web_root\validator.exe"

rem copy all devroot:
xcopy /S /A dev_root\*.* web_root\*.*

rem ------------------------------------------------------------------------------->
call deploy_task.bat 01_Form_01
call deploy_task.bat 01_Form_02
call deploy_task.bat 01_Form_03
call deploy_task.bat 01_Form_04
call deploy_task.bat 01_Form_05
call deploy_task.bat 01_Form_06
call deploy_task.bat 02_Button_01
call deploy_task.bat 02_Button_02
call deploy_task.bat 03_Label_01
call deploy_task.bat 00_test_01
rem ------------------------------------------------------------------------------->