<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_01";
$cls_Task->s_id = "01_Form_01";
$cls_Task->s_description = "Моя власна програма із Windows формою";

$cls_Task->_add_step("1. Додати новий проект <b>Form_01</b> у створене рішення <b>Lesson_01</b>.");
$cls_Task->_add_step("2. Створити Windows форму відповідно специфікації.");
$cls_Task->_add_step("3. Вибрати зі списку потрібну для компіляції програму: <a href='https://learn.ztu.edu.ua/mod/lesson/view.php?id=9977&pageid=5' target='_blank'><img src='../../_img/info.png'></a>");
$cls_Task->_add_step("4. Скомпілювати Windows форму, натиснувши зелений трикутник.");
$cls_Task->_add_step("5. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("6. Добитися повної валідації програми.");
$cls_Task->_add_step("7. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b>.");
$cls_Task->_add_step("8. Скопіювати програму у папку <b>Production</b>.");
$cls_Task->_add_step("9. Зберегти проект та закрити рішення.");

$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("<span class=''>Для коректної валідації програми: властивість <b>AutoScaleMode</b> - значення <b>None</b></span>");

$cls_Task->_add_property("Solution name", "Ім'я рішення", "Lesson_01");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_01.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Прізвище Ім'я");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=9976";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?t=4m51s";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>