<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Square";
$cls_Task->s_id = "02_Square";
$cls_Task->s_description = "Квадрат";

$cls_Task->_add_step("<b>Опис:</b> <i>даний додаток дозволяє при введені сторони квадрату обрахувати та вивести його периметр, площу та діагональ.</i>");
$cls_Task->_add_step("1. Створити або додати проект <b>Square</b> у рішенні <b>Math</b>");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");
$cls_Task->_add_screen("Вигляд програми","0.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Square.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "Квадрат");
$cls_Task->_add_property("Size.Width", "Ширина форми (в пікселях)", "600");
$cls_Task->_add_property("Size.Height", "Висота форми (в пікселях)", "600");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "20");
$cls_Task->_block_end();

$cls_Task->_block_start("Розмістити об'єкти на формі:", "_form.png");
$cls_Task->_add_screen("","1.png");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Info");
$cls_Task->_add_property("Text", "Текст", "Введіть сторону квадрату");
$cls_Task->_add_property("Font.Bold", "Жирний", "true");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: TextBox (текстове поле)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "tb_Input");
$cls_Task->_add_property("Text", "Текст", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: PictureBox (контейнер малюнка)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "pb_Square");
$cls_Task->_add_property("Size.Width", "Ширина", "250");
$cls_Task->_add_property("Size.Height", "Висота", "250");
$cls_Task->_add_property("BackgroundImage", "Зображення", "Square.png");
$cls_Task->_add_property("BackgroundImageLayout", "Спосіб відображення", "Zoom");
$cls_Task->_add_screen("Зображення квадрату завантажити в Resourses","Square.png");
$cls_Task->_block_end();


$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Side");
$cls_Task->_add_property("Text", "Текст", "Сторона: 0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Perimeter");
$cls_Task->_add_property("Text", "Текст", "Периметр: 0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Square");
$cls_Task->_add_property("Text", "Текст", "Площа: 0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Diagonal");
$cls_Task->_add_property("Text", "Текст", "Діагональ: 0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Button (кнопка)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "btn_Calculate");
$cls_Task->_add_property("Size.Width", "Ширина ", "250");
$cls_Task->_add_property("Size.Height", "Висота", "50");
$cls_Task->_add_property("Text", "Текст", "Розрахувати");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_Calculate</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Calculate_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Написати код обробника події <b>btn_Calculate_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "

 //Ініціалізація сторони та її зчитування
double Side = double.Parse(tb_Input.Text);
//Ініціалізація периметра, площі та діагоналі та їх обрахунок 
double Perimeter = Side * 4;
double Square = Side * Side;
double Diagonal = Side * Math.Pow(2, 0.5);
//Виведення сторони, периметра, площі та діагоналі
lb_Side.Text = \"Сторона: \" + Side.ToString(\"#.##\");
lb_Perimeter.Text = \"Периметр: \" + Perimeter.ToString(\"#.##\");
lb_Square.Text = \"Площа: \" + Square.ToString(\"#.##\");
lb_Diagonal.Text = \"Діагональ: \" + Diagonal.ToString(\"#.##\");

", "");
$cls_Task->_add_property("lb_Side.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Perimeter.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Square.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Diagonal.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_screen("Вигляд програми після введення значення та натискання на кнопку <b>Разрахувати</b>","2.png");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Button (кнопка)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "btn_Close");
$cls_Task->_add_property("Size.Width", "Ширина ", "250");
$cls_Task->_add_property("Size.Height", "Висота", "50");
$cls_Task->_add_property("Text", "Текст", "Закрити");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_Close</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Close_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Написати код події <b>btn_Close_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код, який закриє програму:", "Close();", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Author");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "12");
$cls_Task->_add_property("ForeColor", "Колір тексту", "ControlDarkDark");
$cls_Task->_add_property("Text", "Текст ", "<i>Ввести інформацію про автора згідно зразка</i>");
$cls_Task->_block_end();

$cls_Task->_add_screen("Вигляд програми","0.png");

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>