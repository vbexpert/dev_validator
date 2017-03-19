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

if not exist tasks_source_code\%s_task_parent_title% mkdir tasks_source_code\%s_task_parent_title%
if not exist tasks_source_code\%s_task_parent_title%\%s_task_title%%s_task_id% mkdir tasks_source_code\%s_task_parent_title%\%s_task_title%%s_task_id%

set s_task_fp=tasks_source_code\%s_task_parent_title%\%s_task_title%%s_task_id%

rem clone template:
xcopy /s/y "%s_task_clone_from%\*" "%s_task_fp%\*"
@echo on
rem adjust contents:
powershell -Command "(Get-Content %s_task_fp%\task.php).replace('[task_title]', '%s_task_title%') | Set-Content %s_task_fp%\task.php"
powershell -Command "(Get-Content %s_task_fp%\task.php).replace('[task_id]', '%s_task_id%') | Set-Content %s_task_fp%\task.php"

move %s_task_fp%\task_template.csproj %s_task_fp%\%s_task_title%%s_task_id%.csproj

pause