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
set s_task_name="01_Form_01"

rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir="tasks_source_code\%s_task_name%"
set s_task_web_root_dir=web_root\tasks\%s_task_name%
rem 3. сборка для web_root:
mkdir %s_task_web_root_dir%
xcopy /S /A %s_task_dev_dir% %s_task_web_root_dir%
rem ------------------------------------------------------------------------------->
set s_task_name="01_Form_02"

rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir="tasks_source_code\%s_task_name%"
set s_task_web_root_dir=web_root\tasks\%s_task_name%
rem 3. сборка для web_root:
mkdir %s_task_web_root_dir%
xcopy /S /A %s_task_dev_dir% %s_task_web_root_dir%
rem ------------------------------------------------------------------------------->
set s_task_name="01_Form_03"

rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir="tasks_source_code\%s_task_name%"
set s_task_web_root_dir=web_root\tasks\%s_task_name%
rem 3. сборка для web_root:
mkdir %s_task_web_root_dir%
xcopy /S /A %s_task_dev_dir% %s_task_web_root_dir%
rem ------------------------------------------------------------------------------->