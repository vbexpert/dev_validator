rem global:
set s_xampp_web_root=c:\xampp\htdocs

if not exist "%s_xampp_web_root%\validator" mkdir "%s_xampp_web_root%\validator"

rem deploy web root:
xcopy /s/y "web_root\*" "%s_xampp_web_root%\validator\*"

start "" http://127.0.0.1/validator/tasks/5.1.0/task.php