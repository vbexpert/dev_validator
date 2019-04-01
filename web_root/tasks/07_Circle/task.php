<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//titles:
$cls_Task->s_title = "Circle";
$cls_Task->s_id = "07_Circle";
$cls_Task->s_description = "Коло";

//steps:
$cls_Task->_add_step("1. Запустити <b>Visual Studio</b>.");

//f screen:
$cls_Task->_add_screen("Кінцевий вигляд Форми:", "target_form.png");

//help:
$cls_Task->s_youtube_url = "https://youtu.be/VGgci4rdczI";
$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=9976";
$cls_Task->s_youtube_url = "https://youtu.be/8uyRd-aKlSI";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>