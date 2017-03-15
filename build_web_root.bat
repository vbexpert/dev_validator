if not exist "web_root\uploadds" mkdir "web_root\uploadds"
echo 0>"web_root\uploadds\0"
if not exist "web_root\tasks" mkdir "web_root\tasks"
echo 0>"web_root\tasks\0"
rem deploy main exe to web root:
copy "dev_validator_C\bin\Debug\validator.exe" "web_root\validator.exe"

rem winforms5.1.0
set s_task_name=5.1.0
set s_task_dev_dir=winforms5.1\winforms5.1.0

rem ------------------------------------------------------------------------------->
mkdir "web_root\tasks\%s_task_name%"
copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"
copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt"
copy "%s_task_dev_dir%\addition.png" "web_root\tasks\%s_task_name%\addition.png"
rem ------------------------------------------------------------------------------->