<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "07_Rectangular_Triangle";
$cls_Task->s_id = "07_Rectangular_Triangle";
$cls_Task->s_description = "Прямокутний трикутник - Rectangular Triangle";

$cls_Task->_add_step("1. Створити проект <b>Rectangular_Triangle</b> відповідно специфікації у рішенні <b>Math</b> .");
$cls_Task->_add_step("2. Завантажити програму у <b>C-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("3. Детальна інструкція <a href=\"http://informatics.in.ua/programming_csharp/part_05.php\" target=\"_blank\">informatics.in.ua</a>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");
$cls_Task->_add_screen("Вигляд програми","0.png");



$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Rectangular_Triangle");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Заголовок Форми", "Прямокутний трикутник - Rectangular Triangle");
$cls_Task->_add_property("Width", "Ширина форми", "800");
$cls_Task->_add_property("Height", "Висота форми", "300");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "14");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_add_screen("Вигляд програми","1.png");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label1");
$cls_Task->_add_property("Text", "Текст ", "Перший катет:");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_SideA");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label2");
$cls_Task->_add_property("Text", "Текст ", "Другий катет:");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_SideB");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label3");
$cls_Task->_add_property("Text", "Текст ", "Гіпотенуза =");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label4");
$cls_Task->_add_property("Text", "Текст ", "Периметр =");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label5");
$cls_Task->_add_property("Text", "Текст ", "Площа =");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_SideC");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Perimeter");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Square");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();


$cls_Task->_block_start("Додати новий компонент: PictureBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я зображення", "pictureBox1");
$cls_Task->_add_property("BackgroundImage", "Зображення", "Rectangular_Triangle.png");
$cls_Task->_add_property("BackgroundImageLayout", "Спосіб відображення", "Zoom");
$cls_Task->_add_screen("Прямокутний трикутник","Rectangular_Triangle.png");

$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Button", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "btn_Calculate");
$cls_Task->_add_property("Text", "Текст", "Обчислити");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_Calculate</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Calculate_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Написати код події <b>btn_Calculate_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "
Детальна інструкція <a href=\"http://informatics.in.ua/programming_csharp/part_05.php\" target=\"_blank\">informatics.in.ua</a>
", "");
$cls_Task->_add_screen("На даному етапі Валідатор введе випадкові дані у відправлену програму, прочитає результат і порівняє з правильним.","info.png");
$cls_Task->_add_property("lb_SideC.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Perimeter.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Square.Text", "Текст ", "<i>Розраховані програмою значення</i>");

$cls_Task->_add_screen("Вигляд програми після введення значення та натискання на кнопку","2.png");
$cls_Task->_block_end();


$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>