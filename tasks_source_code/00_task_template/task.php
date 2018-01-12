<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "[task-title]";
$cls_Task->s_id = "[task-id]";
$cls_Task->s_description = "[task-description]";
[step-instructions]
[properties-validation-block-php]
$cls_Task->s_youtube_url = "[url-yutube]";
$cls_Task->s_discuss_url = "[url-discussion]";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>