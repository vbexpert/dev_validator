<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_08";
$cls_Task->s_id = "02_Button_08";
$cls_Task->s_description = "Перевірка на введення цифр";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Number.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Перевірка на введення цифр");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "450");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "300");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_add_property("Form.Font.Size", "Розмір шрифту", "20");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Label");
$cls_Task->_add_property("Name", "Ім'я ", "label1");
$cls_Task->_add_property("label1.Text", "Текст кнопки", "Введіть ціле число");
$cls_Task->_add_property("label1.Font.Bold", "Жирний текст", "True");

$cls_Task->_add_object_creator("Додати об'єкт: ", "TextBox");
$cls_Task->_add_property("Name", "Ім'я кнопки", "tb_Input");
$cls_Task->_add_property("tb_Input", "Текст ", "");
$cls_Task->_add_property("tb_Input.Width", "Ширина (в пікселях)", "300");
$cls_Task->_add_code("Обробник події KeyPress:", "
char number = e.KeyChar;
           
     if ((number < 48 || number > 57) && number !=8)
      {
        e.Handled = true;                
      }


", "");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Button");
$cls_Task->_add_property("Name", "Ім'я ", "btn_Close");
$cls_Task->_add_property("btn_Close.Width", "Ширина  (в пікселях)", "300");
$cls_Task->_add_property("btn_Close.Height", "Висота (в пікселях)", "50");
$cls_Task->_add_code("Обробник події Click:", "

Написати самостійно код, що закриває форму!

", "");


$cls_Task->_add_property("btn_ChangeText.Text", "Текст кнопки", "Напис на кнопці змінено!!!");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>