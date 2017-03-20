if not exist "web_root\uploadds" mkdir "web_root\uploadds"
echo 0>"web_root\uploadds\0"
if not exist "web_root\tasks" mkdir "web_root\tasks"
echo 0>"web_root\tasks\0"
rem deploy main exe to web root:
copy "dev_validator_C\bin\Debug\validator.exe" "web_root\validator.exe"

rem ------------------------------------------------------------------------------->
rem сборка таска: winforms5.1.1
rem 1. имя таска:
set s_task_name=winforms5.1.1
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\5.1winforms\winforms5.1.1
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: winforms5.1.2
rem 1. имя таска:
set s_task_name=winforms5.1.2
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\5.1winforms\winforms5.1.2
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: winforms5.1.3
rem 1. имя таска:
set s_task_name=winforms5.1.3
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\5.1winforms\winforms5.1.3
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: winforms5.1.4
rem 1. имя таска:
set s_task_name=winforms5.1.4
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\5.1winforms\winforms5.1.4
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

