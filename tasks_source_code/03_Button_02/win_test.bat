cd ..\..\
set s_task_id=01_Form_01
set s_task_exe=Form_01.exe

dev_validator_C\bin\Debug\validator.exe tasks_source_code\%s_task_id%\bin\Debug\%s_task_exe% tasks_source_code\%s_task_id%\code.txt %s_task_exe%
pause