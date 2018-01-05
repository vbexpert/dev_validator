<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_01";
$cls_Task->s_id = "01_Form_01";
$cls_Task->s_description = "Моя власна програма із Windows формою";

$cls_Task->_add_step("1. Додати новий проект <b>Form_01.exe</b> у створене рішення <b>Lesson_01.exe</b>.");
$cls_Task->_add_step("2. Створити Windows форму відповідно специфікації.");
$cls_Task->_add_step("3. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("4. Добитися повної валідації програми.");
$cls_Task->_add_step("5. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b>.");
$cls_Task->_add_step("6. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Solution name", "Ім'я рішення", "Lesson_01.exe");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_01.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Прізвище Ім'я");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=9976";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>