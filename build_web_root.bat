if not exist "web_root\uploads" mkdir "web_root\uploads"
echo 0>"web_root\uploads\0"
if not exist "web_root\tasks" mkdir "web_root\tasks"
echo 0>"web_root\tasks\0"
rem deploy main exe to web root:
copy "dev_validator_C\bin\Debug\validator.exe" "web_root\validator.exe"

rem ------------------------------------------------------------------------------->
rem сборка таска: 01_Form_01
rem 1. имя таска:
set s_task_name=01_Form_01
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\01_Form\01
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: 01_Form_02
rem 1. имя таска:
set s_task_name=01_Form_02
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\01_Form\02
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: 01_Form_03
rem 1. имя таска:
set s_task_name=01_Form_03
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\01_Form\03
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: 01_Form_04
rem 1. имя таска:
set s_task_name=01_Form_04
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\01_Form\04
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: 01_Form_05
rem 1. имя таска:
set s_task_name=01_Form_05
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\01_Form\05
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: 02_Button_01
rem 1. имя таска:
set s_task_name=02_Button_01
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\02_Button\01
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: 02_Button_02
rem 1. имя таска:
set s_task_name=02_Button_02
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\02_Button\02
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->



rem ------------------------------------------------------------------------------->
rem сборка таска: 04_TextBox_01
rem 1. имя таска:
set s_task_name=04_TextBox_01
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\04_TextBox\01
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->

rem ------------------------------------------------------------------------------->
rem сборка таска: 50_Click_01
rem 1. имя таска:
set s_task_name=50_Click_01
rem 2. путь до базовой директории проекта таска:
set s_task_dev_dir=tasks_source_code\50_Click\01
rem 3. сборка для web_root:
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png"
rem ------------------------------------------------------------------------------->