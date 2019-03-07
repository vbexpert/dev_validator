cd ..\..\
set s_task_id=06_2d_graphics_01
set s_task_exe=drawing01.exe

dev_validator_C\bin\Debug\validator.exe tasks_source_code\%s_task_id%\bin\Debug\%s_task_exe% tasks_source_code\%s_task_id%\code.txt %s_task_exe%
pause