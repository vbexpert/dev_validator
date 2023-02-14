<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//titles:
$cls_Task->s_title = "Form_00";
$cls_Task->s_id = "01_Form_00";
$cls_Task->s_description = "Створення простої Windows форми";

//steps:
$cls_Task->_add_step("1. Запустити <b>Visual Studio</b>.");
$cls_Task->_add_step("2. Створити новий проект.");
$cls_Task->_add_step("3. Вибрати шаблон <b>Visual C# - Приложение Windows Forms</b>.");
$cls_Task->_add_step("4. Назвати проект <b>Form_00</b>.");
$cls_Task->_add_step("5. Вибрати розміщення у власну папку.");
$cls_Task->_add_step("6. Назвати рішення <b>WindowsForms</b>.");
$cls_Task->_add_step("7. Натиснути <b>ОК</b> для створення проекту.");
$cls_Task->_add_step("https://youtu.be/8uyRd-aKlSI");
$cls_Task->_add_step("8. Скомпілювати Windows форму, натиснувши зелений трикутник.");
$cls_Task->_add_step("9. Закрити Windows форму.");
$cls_Task->_add_step("10. Зберегти всі файли та закрити середовище програмування <b>Visual Studio</b>.");
$cls_Task->_add_step("11. Знайти та запустити створену Windows форму.</b>");
$cls_Task->_add_step("12. Відкрити власну папку.");
$cls_Task->_add_step("13. Знайти в ній створену програму <b>WindowsForms\Form_00\bin\Debug\</b>.");
$cls_Task->_add_step("14. Запустити  файл <b>Form_00.exe</b>");
$cls_Task->_add_step("15. Закрити Windows форму.");
$cls_Task->_add_step("16. Виконати процедуру перевірки програми.");
$cls_Task->_add_step("17. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("18. Добитися повної валідації програми.");
$cls_Task->_add_step("19. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b>.");
$cls_Task->_add_step("20. Скопіювати програму <b>Form_00.exe</b> у папку <b>Production</b>.");

//validation blocks:
$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_00");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");

//f screen:
$cls_Task->_add_screen("Кінцевий вигляд Форми:", "target_form.png");

//help:
$cls_Task->s_youtube_url = "https://youtu.be/VGgci4rdczI";
$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=9976";
$cls_Task->s_youtube_url = "https://youtu.be/8uyRd-aKlSI";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>