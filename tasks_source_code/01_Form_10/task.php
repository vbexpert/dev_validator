<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_10";
$cls_Task->s_id = "01_Form_10"; //_exact_ folder name!
$cls_Task->s_description = "Не відображати програму в Панелі задач";

$cls_Task->_add_step("1. Відкрити створене рішення <b>Lesson_01</b>.");
$cls_Task->_add_step("2. Додати у рішення новий проект <b>Form_10</b>.");
$cls_Task->_add_step("3. Створити форму відповідно специфікації.");
$cls_Task->_add_step("4. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("5. Добитися повної валідації програми.");
$cls_Task->_add_step("6. Зберегти скріншот результатів у папку <b>Production</b>.");
$cls_Task->_add_step("7. Скопіювати програму у папку <b>Production</b>.");
$cls_Task->_add_step("8. Зберегти проект та закрити рішення.");

$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("Для коректної валідації програми встановіть властивості <b>AutoScaleMode</b> значення <b>None</b>");

$cls_Task->_add_property("Solution name", "Ім'я рішення", "Lesson_01");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_10.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Не відображати програму в Панелі задач");
$cls_Task->_add_property("Form.WindowState", "Режим вікна", "Розгорнуте на весь екран");
$cls_Task->_add_property("Form.ShowIcon", "Не відображати іконку програму у заголовку", "False");	
$cls_Task->_add_property("Form.ShowInTaskbar", "Не відображати програму в Панелі задач", "False");	


$cls_Task->s_learn_url = "https://msdn.microsoft.com/ru-ru/library/system.windows.forms.form.showintaskbar(v=vs.110).aspx";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>