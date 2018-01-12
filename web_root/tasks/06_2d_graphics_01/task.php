<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Моя перша лінія!";
$cls_Task->s_id = "06_2d_graphics_01"; //_exact_ folder name!
$cls_Task->s_description = "Моя перша лінія!";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у DEV-VALIDATOR.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку Production.");
$cls_Task->_add_step("5. Зберегти програму у папку Production.");

$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Application name", "Ім'я програми", "drawing01.exe");
$cls_Task->_add_property("Form", "Form.Width", "800");
$cls_Task->_add_property("Form", "Form.Height", "400");
$cls_Task->_add_property("Form.Text", "Form.Text", "Моя перша лінія!");

$cls_Task->_add_property("<span class=\"btn btn-success\"> Додати об'єкт </span>", "<h5>PictureBox</h5>", "");
$cls_Task->_add_property("PictureBox", "PictureBox.Width", "600");
$cls_Task->_add_property("PictureBox", "PictureBox.Height", "300");
$cls_Task->_add_property("PictureBox", "PictureBox.Top", "12");
$cls_Task->_add_property("PictureBox", "PictureBox.Left", "12");

$cls_Task->_add_property("<span class=\"btn btn-success\"> Додати об'єкт </span>", "<h5>Button</h5>", "");
$cls_Task->_add_property("Button.Width", "Button.Width", "150");
$cls_Task->_add_property("Button.Height", "Button.Height", "35");
$cls_Task->_add_property("Button.Top", "Button.Top", "12");
$cls_Task->_add_property("Button.Left", "Button.Left", "618");
$cls_Task->_add_property("Button.Text", "Button.Text", "Намалювати лінію!");

$cls_Task->s_youtube_url = "[url-yutube]";
$cls_Task->s_discuss_url = "[url-discussion]";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>