<?php
require("main_config.php");
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
header('Content-Type: text/html; charset=utf-8');
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");
//access wall:
if($b_use_access_wall){
  require("access_wall.php");
}
?>
<html>
  <head>
    <!-- title -->
    <title><?php echo($cls_Task->s_title); ?></title>
	<?php
	  include_once("head_meta_tags.php");
	?>
	<!-- external CSS: -->
    <link rel="stylesheet" type="text/css" href="../../_css/global.css">
</head>
<body>

  <div class="container">
    <div class="starter-template">

    <!-- header info block start: -------------------------------------------------------------------------------->
    <!-- header info block end: ---------------------------------------------------------------------------------->
    <div class="jumbotron task_jumbotron_height_fix">
      <!-- task info block start --------------------------------------------------------------------------------->
      <!-- <h2 class=''><a href = "../../index.php">Назад до Індексу Завдань</a></h2> 
      <hr> -->
	  
    <!-- menu stat: -->
	<?php
      include_once("../../nav_menu.php");
    ?>
    <!-- menu end: -->
	  
      <h1 class=""><?php echo($cls_Task->s_title); ?></h1>
      <h3 class=""><?php echo($cls_Task->s_description); ?></h3>
      <hr>
	  <?php
	    foreach ($cls_Task->oa_steps as $s_step){
		  echo("<p class='lead lead-top-fix'>".$s_step."</p>");
		}
	  ?>
      <hr>
      <table class="table table-striped table-bordered">
        <caption class='app_specs' align="top">Специфікація програми:</caption>
          <thead >
            <tr >
              <th>Property:</th>
              <th>Властивість:</th>
              <th>Значення:</th>
              <th>Валідація:</th>
            </tr>
          </thead>
		  <?php
		  //var_dump($cls_Task->oa_properties);
		  $i_ctr = 0;
		  foreach ($cls_Task->oa_properties as $cls_property){
			//---> pacth with session vars:
			if(isset($_SESSION["vr_percent"])){
			  $s_s_title="vr".$i_ctr."_reslt";
			  $cls_property->b_validated = $_SESSION[$s_s_title];
			  //destroy session var:
			  $_SESSION[$s_s_title] = "";
			}
			//<--
			echo("<tr>");
			  echo("<td>".$cls_property->s_name."</td>");
			  echo("<td>".$cls_property->s_title."</td>");
			  echo("<td>".$cls_property->s_master_value."</td>");
			  switch ($cls_property->s_type) {
				case "":
					$s_checked = "";
					if($cls_property->b_validated == true){
					  $s_checked = "checked";
					}
					echo("<td><div class='chkbox-v-value'><input type='checkbox' $s_checked data-off-icon-cls=\"gluphicon-thumbs-down\" data-on-icon-cls=\"gluphicon-thumbs-up\"></input></div></td>");
					break;
				case "obj_creator":
					echo("<td></td>");
					break;					
				case "code":
					echo("<td></td>");
					break;
			  }
			echo("</tr>");
			$i_ctr++;
          }
		  ?>
        </table>
		
	    <div class="progress">
		  <div class="progress-bar progress-bar-success progress-bar-striped pb-v-progress" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width:<?php echo($_SESSION["vr_percent"]); ?>%">
			<div class='pb-v-text'>
			  <?php 
			    if(isset($_SESSION["vr_percent"])){
			      echo($_SESSION["vr_percent"]); 
				}
			    else{
				  echo(0);
				}
			  ?> % вірно!
			</div>
		  </div>
		</div>
		
        <div class="row f_img_holder">
          <img class='f_img' src="target_form.png" />
        </div>
		
		<!-- footer start ------------------------------->
		
	    <!-- help block start -->
         <div style="text-align: center;"> 
           <a class="btn btn-info regular_button" href="<?php echo($cls_Task->s_learn_url); ?>" role="button" target="_blank">Почитати навчальний матеріал</a>
           <a class="btn btn-danger regular_button" href="<?php echo($cls_Task->s_youtube_url); ?>" role="button" target="_blank">Подивитись відеоурок</a>
           <a class="btn btn-warning regular_button" href="<?php echo($cls_Task->s_discuss_url) ?>" role="button" target="_blank">Обговорити у спільноті</a>
         </div>
	    <!-- help block end -->
		
		<hr>

        <!-- task validation block start ---------------->
		<div class="container">
		  <div class="row">
			<div class="col-md-4">
			  <div class='check_btn_label'>Перевірка:</div>
			</div>
			<div class="col-md-4">
			<form id='upload_file' class='upload_file' action="..\..\validator_fe.php" method="post" enctype="multipart/form-data">
			  <label class="btn btn-primary regular_button">
				Вибрати файл програми<input type="file" hidden id="fileToUpload" name="fileToUpload">
			  </label>
			  <input type="hidden" name="codefile" value="<?php echo($cls_Task->s_id) ?>"/><!-- task id -->
			</form>
			</div>
			<div class="col-md-4">
			  
			</div>
		  </div>
		</div>
		<!-- task validation block end ------------------>
		
		<!-- footer end --------------------------------->
		
		</div>
      </div>
    </div>
	
<!-- modal msg start ------------------------------------>
<div class="container">
  <!-- test rigger -->
  <!-- <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Open Modal</button> -->
  
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Вітаємо із маленькою перемогою!</h4>
        </div>
        <div class="modal-body modal-task-complete">
		  <div class='task-completed-img'><img src='../../_img/task-completed.png' /></div>
          <div>Завдання виконано на 100%!</div>
		  <div>Програмуй наступне!</div>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal" onclick='history.go(-1);'>Закрити</button>
        </div>
      </div>
   
    </div>
  </div>
  
</div>
<!-- modal msg end -------------------------------------->

<script>
$(function() {
	$('#fileToUpload').change(function(){ 
		$('#upload_file').submit();
	});
	<!-- Initialize highlight -->
	hljs.initHighlightingOnLoad();
	<!-- Initialize checkboxpicker -->
	$(':checkbox').checkboxpicker();
});

</script>
	
</body>
  
<?php

//show completed window on 100%:
if($_SESSION["vr_percent"] == 100){
  echo("<script>$('#myModal').modal('show');</script>");
}

//destory session vars with validation results:
$_SESSION["vr_percent"] = "0";

if($b_do_debug){
  echo("<pre>");
  var_dump($_SESSION);
  echo("</pre>");
}
?>

</html>