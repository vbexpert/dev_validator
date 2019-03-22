<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_13";
$cls_Task->s_id = "01_Form_13"; //_exact_ folder name!
$cls_Task->s_description = "Розтягнення фонового малюнку";

$cls_Task->_add_step("1. Відкрити створене рішення <b>WindowsForms</b>.");
$cls_Task->_add_step("2. Додати у рішення новий проект <b>Form_13</b>.");
$cls_Task->_add_step("3. Знайти та зберегти у папку з проектом зображення <b>Космос</b>.");
$cls_Task->_add_step("4. Фоновий малюнок імпортувати в <b>Resourses</b>.");
$cls_Task->_add_step("5. Створити форму відповідно специфікації.");
$cls_Task->_add_step("6*. Змінювати розміри вікна програми, перетягуючи границі і спостерігати за поведінкою малюнку.");
$cls_Task->_add_step("7. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("8. Добитися повної валідації програми.");
$cls_Task->_add_step("9. Зберегти скріншот результатів у папку <b>Production</b>.");
$cls_Task->_add_step("10. Скопіювати програму у папку <b>Production</b>.");
$cls_Task->_add_step("11. Зберегти проект та закрити рішення.");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_13");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Заголовок форми", "Stretch - Розтягнення фонового малюнку");
$cls_Task->_add_property("BackgroundImage", "Фонове зображення", "завантажити в Resoures зображення космосу");
$cls_Task->_add_property("BackgroundImageLayout", "Спосіб відображення фонового малюнку", "Stretch");

$cls_Task->_add_screen("Кінцевий вигляд Форми:", "target_form.png");

$cls_Task->s_learn_url = "https://msdn.microsoft.com/ru-ru/library/system.windows.forms.imagelayout(v=vs.110).aspx";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>