rem wipe web-root:
del /f /s /q web_root\*.*
rmdir /s /q web_root
if not exist "web_root" mkdir "web_root"

rem wipe app_for_testing:
del /f /s /q app_for_testing\*.*
rmdir /s /q app_for_testing
if not exist "app_for_testing" mkdir "app_for_testing"

rem create filders:
if not exist "web_root\uploads" mkdir "web_root\uploads"
if not exist "web_root\tasks" mkdir "web_root\tasks"
echo 0>"web_root\uploads\0"

rem delpoy validator.exe:
copy "dev_validator_C\bin\Debug\validator.exe" "web_root\validator.exe"

rem copy all devroot:
xcopy /S /A dev_root\*.* web_root\*.*
rem ------------------------------------------------------------------------------->
rem iterate via all tasks, deploy each of them to web root:
FOR /f "tokens=*" %%i in ('DIR /a:d /b tasks_source_code\*') DO (
    rem ECHO %%i
	call deploy_task_XAMPP.bat %%i
)
rem ------------------------------------------------------------------------------->


