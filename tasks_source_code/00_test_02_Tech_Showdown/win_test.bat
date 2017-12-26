cd ..\..\
set s_task_id=00_test_02_Tech_Showdown
set s_task_exe=TestTask_02.exe

dev_validator_C\bin\Debug\validator.exe tasks_source_code\%s_task_id%\bin\Debug\%s_task_exe% tasks_source_code\%s_task_id%\code.txt %s_task_exe%
pause