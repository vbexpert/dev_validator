<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Label_00";
$cls_Task->s_id = "03_Label_00";
$cls_Task->s_description = "Додавання напису на форму";

$cls_Task->_add_step("1. Створити проект <b>Label_00</b> у рішенні <b>Label</b>");
$cls_Task->_add_step("2. Створити форму відповідно специфікації.");
$cls_Task->_add_step("3. Додати на форму напис з <b>Панелі елементів</b>.");
$cls_Task->_add_step("4. Завантажити програму у <b>С-VALIDATOR</b>.");
$cls_Task->_add_step("5. Добитися повної валідації програми.");
$cls_Task->_add_step("6. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("7. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Label_00");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Додавання напису на форму");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати об'єкт: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я кнопки", "label1");
$cls_Task->_add_property("Text", "Текст кнопки", "label1");
$cls_Task->_add_screen("Кінцевий вигляд програми:", "0.png");

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>