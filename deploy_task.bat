rem @echo off
set "s_task_name=%1"
rem 2. путь до базовой директории проекта таска:
set "s_task_dev_dir=tasks_source_code\%s_task_name%"
set "s_task_web_root_dir=web_root\tasks\%s_task_name%"
rem 3. сборка для web_root:
mkdir %s_task_web_root_dir%
xcopy /S /A %s_task_dev_dir% %s_task_web_root_dir%