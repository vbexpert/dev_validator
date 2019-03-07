<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_09";
$cls_Task->s_id = "02_Button_09";
$cls_Task->s_description = "Перевірка числа на рівність нулю";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Null.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Перевірка числа на рівність нулю");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "450");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "600");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");

$cls_Task->_add_object_creator("Додати об'єкти: ", "Згідно скріншоту");


$cls_Task->_add_object_creator("Створити подію для: ","btn_Start");
$cls_Task->_add_code("Написати код:", "
private void btn_Start_Click(object sender, EventArgs e)
        {
            int number = Int16.Parse(tb_Input.Text);
            if (number == 0)
            {
                rtb_Result.Text = \"Ви ввели нуль\";
            } else
            {
                rtb_Result.Text = \"Ви ввели число відмінне від нуля\";
            }
        }

", "");



$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>