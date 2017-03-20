@echo off
rem set clone parent:
set s_task_clone_from=tasks_source_code\task_template\template
rem ask for parent folder:
set /p s_task_parent_title="Enter task parent folder title: "
echo "parent folder set to: %s_task_parent_title%"
rem ask task title:
set /p s_task_title="Enter task title: "
echo "task title set to: %s_task_title%"
rem ask task id:
set /p s_task_id="Enter task id: "
echo "task id set to: %s_task_id%"

rem add comands to build_web_root.bat

echo set s_task_name=%s_task_title%%s_task_id% >> 1.bat
echo set s_task_dev_dir=tasks_source_code\%s_task_parent_title%\%s_task_title%%s_task_id% >> 1.bat
echo mkdir "web_root\tasks\%s_task_name%" >> 1.bat
echo %copy "%s_task_dev_dir%\task.php" "web_root\tasks\%s_task_name%\task.php"% >> 1.bat
echo copy "%s_task_dev_dir%\code.txt" "web_root\tasks\%s_task_name%\code.txt" >> 1.bat
echo copy "%s_task_dev_dir%\target_form.png" "web_root\tasks\%s_task_name%\target_form.png" >> 1.bat


pause