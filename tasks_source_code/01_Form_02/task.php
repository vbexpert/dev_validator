<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_02";
$cls_Task->s_id = "01_Form_02";
$cls_Task->s_description = "Розфарбуйте свою Windows форму";

$cls_Task->_add_step("1. Відкрити створене рішення <b>Lesson_01</b>: <a href='https://youtu.be/hP0UsFULLuU?t=6m58s' target='_blank'><img src='../../_img/info.png'></a>");
$cls_Task->_add_step("2. Додати у рішення новий проект <b>Form_02</b>.");
$cls_Task->_add_step("3. Створити форму відповідно специфікації.");
$cls_Task->_add_step("4. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("5. Добитися повної валідації програми.");
$cls_Task->_add_step("6. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b>.");
$cls_Task->_add_step("7. Скопіювати програму у папку <b>Production</b>.");
$cls_Task->_add_step("8. Спробувати інші кольори на закладках <b>Другой Интернет Система</b>.");
$cls_Task->_add_step("9. Зберегти проект та закрити рішення.");

$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("Для коректної валідації програми встановіть властивості <b>AutoScaleMode</b> значення <b>None</b>");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_02.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Розфарбуйте свою Windows форму");
$cls_Task->_add_property("Form.BackColor.Name", "Колір Форми", "CadetBlue");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=9978";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?t=4m51s";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>