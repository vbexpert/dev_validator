<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "[task-title]";
$cls_Task->s_id = "[task-id]"; //_exact_ folder name!
$cls_Task->s_description = "[task-description]";

[step-instructions]

[properties-validation-block-php]
$cls_Task->s_youtube_url = "[url-yutube]";
$cls_Task->s_discuss_url = "[url-discussion]";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>