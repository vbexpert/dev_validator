<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_08";
$cls_Task->s_id = "03_Button_08";
$cls_Task->s_description = "Перевірка на введення цифр";

$cls_Task->_add_step("<b>Опис:</b> <i>даний проект дозволить при введенні даних...</i>");
$cls_Task->_add_step("1. Створити або додати проект <b>Number</b> відповідно специфікації у рішенні <b>Button</b>");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Number.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Перевірка на введення цифр");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "450");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "300");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_add_property("Form.Font.Size", "Розмір шрифту", "20");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я ", "label1");
$cls_Task->_add_property("label1.Text", "Текст напису", "Введіть ціле число");
$cls_Task->_add_property("label1.Font.Bold", "Жирний текст", "True");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: TextBox (текстове поле)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я кнопки", "tb_Input");
$cls_Task->_add_property("tb_Input", "Текст ", "");
$cls_Task->_add_property("tb_Input.Width", "Ширина (в пікселях)", "300");
$cls_Task->_add_code("Обробник події KeyPress:", "char number = e.KeyChar;
     if ((number < 48 || number > 57) && number !=8)
      {
        e.Handled = true;                
      }", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Button (кнопка)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я ", "btn_Close");
$cls_Task->_add_property("btn_Close.Width", "Ширина  (в пікселях)", "300");
$cls_Task->_add_property("btn_Close.Height", "Висота (в пікселях)", "50");

$cls_Task->_block_start("Створити подію для кнопки btn_Close: btn_Close_Click", "_add_event.png");
$cls_Task->_add_code("Обробник події:", "private void btn_Close_Click(object sender, EventArgs e)
        {

        }", "");

$cls_Task->_block_start("Написати код, що закриває форму самостійно!", "_add_code.png");
$cls_Task->_add_code("Обробник події:", "private void btn_Close_Click(object sender, EventArgs e)
        {
            ???
        }", "");


$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>