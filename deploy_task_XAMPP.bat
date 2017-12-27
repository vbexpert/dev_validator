rem @echo off
set "s_task_name=%1"
rem 2. путь до базовой директории проекта таска:
set "s_task_dev_dir=tasks_source_code\%s_task_name%"
set "s_task_web_root_dir=web_root\tasks\%s_task_name%"
rem 3. сборка для web_root:
mkdir %s_task_web_root_dir%
copy %s_task_dev_dir%\code.txt %s_task_web_root_dir%\code.txt
copy %s_task_dev_dir%\task.php %s_task_web_root_dir%\task.php
copy %s_task_dev_dir%\target_form.png %s_task_web_root_dir%\target_form.png