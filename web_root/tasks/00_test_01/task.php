<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//--------------------------------------->
//create UI validation webpage:
$cls_Task->s_title = "Test Task 00";
$cls_Task->s_id = "00_test_01"; //_exact_ folder name!
$cls_Task->s_description = "Нове классне завдання із кнопкою!";

//add steps:
//$cls_Task->_add_step("[step-instruction]");
//$cls_Task->_add_step("1. Детальний опис крока - українською!");
$cls_Task->_add_step("2. Детальний опис крока - українською!");
$cls_Task->_add_step("3. Детальний опис крока - українською!");


//add parameters to be validated:
//template:
//$cls_Task->_add_property("Application name", "Ім'я програми", "Form_01.exe");
//$cls_Task->_add_property("Form", "Form.Width", "400");
$cls_Task->_add_property("Form", "Form.Width", "400");
$cls_Task->_add_property("Form", "Form.Width", "400");

$cls_Task->_add_code("Написати код:", "class Child
{
    private int age;
    private string name;

    // Default constructor:
    public Child()
    {
        name = \"N/A\";
    }

    // Constructor:
    public Child(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Printing method:
    public void PrintChild()
    {
        Console.WriteLine(\"{0}, {1} years old.\", name, age);
    }
}", "");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/course/view.php?id=1852";
$cls_Task->s_youtube_url = "https://www.youtube.com/watch?v=hP0UsFULLuU&list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>

