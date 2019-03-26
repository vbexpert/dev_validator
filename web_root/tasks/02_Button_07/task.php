<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_07";
$cls_Task->s_id = "02_Button_07";
$cls_Task->s_description = "Створення обчислювального проекту.";

$cls_Task->_add_step("<b>Опис:</b> <i>даний проект дозволить при натисканні на кнопку збільшити введене в текстове поле число вдвічі і виведе результат в напис. Щоб було приємніше створювати програму, уявіть що збільшуватись будуть ваші введені кошти ;)</i>");
$cls_Task->_add_step("1. Створити проект <b>Multiply</b> відповідно специфікації у рішенні <b>Button</b>.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Multiply");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Збільшення числа вдвічі");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "500");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "300");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "20");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Label - напис");
$cls_Task->_add_property("Name", "Ім'я напису", "lb_Result");
$cls_Task->_add_property("Text", "Текст напису", "Результат");

$cls_Task->_add_object_creator("Додати об'єкт: ", "TextBox - текстове поле");
$cls_Task->_add_property("Name", "Ім'я поля", "tb_Input");
$cls_Task->_add_property("Text", "Текст поля", "");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Button - кнопка");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_Multiply");
$cls_Task->_add_property("Text", "Текст кнопки", "Подвоїти");
$cls_Task->_add_property("Width", "Ширина кнопки", "250");
$cls_Task->_add_property("Height", "Висота кнопки", "50");
$cls_Task->_add_property("btn_Multiply_Click", "При натисканні на кнопку", "Число введене в поле збільшується вдвічі і результат виводиться в напис");

$cls_Task->_add_object_creator("Створити подію для: ","btn_Multiply_Click");
$cls_Task->_add_code("Обробник події:", "private void btn_Multiply_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tb_Input.Text);
            int b = a * 2;
            lb_Result.Text = b.ToString();
        }", "");

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>