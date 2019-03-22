<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_11";
$cls_Task->s_id = "02_Button_11";
$cls_Task->s_description = "Квадрат";

$cls_Task->_add_step("<b>Опис:</b> <i>даний додаток дозволяє при введені цілочисельної сторони квадрату обрахувати та вивести його периметр, площу та діагональ.</i>");
$cls_Task->_add_step("1. Створити або додати проект <b>Square</b> відповідно специфікації у рішенні <b>Button</b>");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Square.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "Квадрат");
$cls_Task->_add_property("Size.Width", "Ширина форми (в пікселях)", "600");
$cls_Task->_add_property("Size.Height", "Висота форми (в пікселях)", "600");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "20");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "lb_Info");
$cls_Task->_add_property("Text", "Текст", "Введіть сторону квадрату");
$cls_Task->_add_property("Font.Bold", "Жирний", "true");

$cls_Task->_block_start("Додати компонент: TextBox (текстове поле)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "tb_Input");
$cls_Task->_add_property("Text", "Текст", "");

$cls_Task->_block_start("Додати компонент: PictureBox (контейнер малюнка)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "pb_Square");
$cls_Task->_add_property("Image", "Зображення", "<i>Знайти в Інтернеті, зберегти  та завантажити малюнок квадрату</i>");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "lb_Side");
$cls_Task->_add_property("Text", "Текст", "Сторона:");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "lb_Perimeter");
$cls_Task->_add_property("Text", "Текст", "Периметр:");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "lb_Square");
$cls_Task->_add_property("Text", "Текст", "Площа:");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "lb_Diagonal");
$cls_Task->_add_property("Text", "Текст", "Діагональ:");

$cls_Task->_block_start("Додати компонент: Button (кнопка)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "btn_Calculate");
$cls_Task->_add_property("Text", "Текст", "Розрахувати");

$cls_Task->_block_start("Додати компонент: Button (кнопка)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "btn_Close");
$cls_Task->_add_property("Text", "Текст", "Закрити");
$cls_Task->_add_property("Size.Width", "Ширина ", "500");
$cls_Task->_add_property("Size.Height", "Висота", "50");

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>