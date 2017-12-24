rem wipa all:
del /f /s /q web_root\*.*
rmdir /s /q web_root
if not exist "web_root" mkdir "web_root"

rem create filders:
if not exist "web_root\uploads" mkdir "web_root\uploads"
if not exist "web_root\tasks" mkdir "web_root\tasks"

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
rem ------------------------------------------------------------------------------->