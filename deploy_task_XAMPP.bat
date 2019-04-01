rem @echo off
set "s_task_name=%1"
rem 2. путь до базовой директории проекта таска:
set "s_task_dev_dir=tasks_source_code\%s_task_name%"
set "s_task_web_root_dir=web_root\tasks\%s_task_name%"
set "s_task_app_dir=%s_task_dev_dir%\bin\Debug"
rem 3. сборка для web_root:
mkdir %s_task_web_root_dir%
copy %s_task_dev_dir%\code.txt %s_task_web_root_dir%\code.txt
copy %s_task_dev_dir%\task.php %s_task_web_root_dir%\task.php
copy "%s_task_dev_dir%\*.png" %s_task_web_root_dir%
rem 4. сборка бинарных файлов для app_for_testing:
set s_task_app=%s_task_name%
set s_task_app=%s_task_app:~1%
set s_task_app=%s_task_app:~1%
set s_task_app=%s_task_app:~1%
copy %s_task_app_dir%\%s_task_app%.exe app_for_testing\%s_task_app%.exe
