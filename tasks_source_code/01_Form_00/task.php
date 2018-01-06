<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_00";
$cls_Task->s_id = "01_Form_00";
$cls_Task->s_description = "Створення простої Windows форми";

$cls_Task->_add_step("1. Запустити <b>Visual Studio</b>.");
$cls_Task->_add_step("2. Створити новий проект.");
$cls_Task->_add_step("3. Вибрати шаблон <b>Visual C# - Приложение Windows Forms</b>.");
$cls_Task->_add_step("4. Назвати проект <b>Form_00</b>.");
$cls_Task->_add_step("5. Вибрати розміщення у власну папку.");
$cls_Task->_add_step("6. Назвати рішення <b>Lesson_01</b>.");
$cls_Task->_add_step("7. Натиснути <b>ОК</b> для створення проекту.");
$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("<b>Уважно ознайомитись з інтерфейсом середовища Visual Studio!</b>");
$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("8. Скомпілювати Windows форму, натиснувши зелений трикутник.");
$cls_Task->_add_step("9. Закрити Windows форму.");
$cls_Task->_add_step("10. Зберегти всі файли та закрити середовище програмування <b>Visual Studio</b>.");
$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("<b>Знайти та запустити створену Windows форму</b>");
$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("11. Відкрити власну папку.");
$cls_Task->_add_step("12. Знайти в ній створену програму <b>Lesson_01\Form_00\bin\Debug\</b>");
$cls_Task->_add_step("13. Запустити  файл <b>Form_00.exe</b>");
$cls_Task->_add_step("14. Закрити Windows форму.");
$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("<b>Виконати процедуру перевірки програми</b>");
$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("15. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("16. Добитися повної валідації програми.");
$cls_Task->_add_step("17. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b>.");
$cls_Task->_add_step("18. Скопіювати програму <b>Form_00.exe</b> у папку <b>Production</b>.");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=9976";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?t=18s";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>