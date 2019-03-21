<?php
//debug:
error_reporting(E_ALL);
ini_set('display_errors', 1);

//utf8 support:
header('Content-Type: text/html; charset=utf-8');

//no cache:
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");

$s_task_page = $_SERVER["REQUEST_URI"];
$_SESSION['s_task_page'] = $s_task_page;

//access wall:
if($b_use_access_wall){
  include($s_v_app_root."access_wall.php");
}
$_SESSION["s_task_id"] = $cls_Task->s_id;
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
      include("../../nav_menu.php");
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
				<div class="row f_img_holder">
          <img class='f_img' src="target_form.png" />
        </div>
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
			//---> patch with session vars:
			if(isset($_SESSION["vr_percent"])){
			  $s_s_title="vr".$i_ctr."_reslt";
			  if(isset($_SESSION[$s_s_title]) && $_SESSION[$s_s_title] != ""){
				
			    $cls_property->b_validated = true;
			    //delete session var:
			    $_SESSION[$s_s_title] = "";
				unset($_SESSION[$s_s_title]);
			  }
			  else{
				$cls_property->b_validated = false;
			  }
			}
			
			//<-- Creating specification table 
			echo("<tr>");
			  if($cls_property->s_type == "code"){
				//============================>
				//code only:
				echo("<td>".$cls_property->s_name."</td>");
				echo("<td colspan='3'>".$cls_property->s_title."</td>");
				//============================>
			  }else{
				//============================>
				//not code:
			    echo("<td>".$cls_property->s_name."</td>");
			    echo("<td>".$cls_property->s_title."</td>");
			    echo("<td>".$cls_property->s_master_value."</td>");
			    switch ($cls_property->s_type) {
				  case "":
					  $s_checked = "";
					  if($cls_property->b_validated == true){
					    $s_checked = "checked=\"checked\"";
					  }
					  echo("<td><div class='chkbox-v-value'><input type='checkbox' $s_checked data-off-icon-cls=\"gluphicon-thumbs-down\" data-on-icon-cls=\"gluphicon-thumbs-up\"></input></div></td>");
					  break;
				  case "obj_creator":
					  echo("<td></td>");
					  break;					
			    }
				//============================>
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
		        <!-- task validation block start ---------------->
		<div class="container">
		  <div class="row">
			<div class="col-md-2">
			  <div class='check_btn_label'>Перевірка:</div>
			</div>
			<div class="col-md-8">
			<form id='upload_file' class='upload_file' action="..\..\validator_fe.php" method="post" enctype="multipart/form-data">
			  <label class="btn btn-success btn-block btn-lg">
				Вибрати файл програми для валідації<input type="file" hidden id="fileToUpload" name="fileToUpload">
			  </label>
			  <input type="hidden" name="codefile" value="<?php echo($cls_Task->s_id) ?>"/><!-- task id -->
			</form>
			</div>
			<div class="col-md-4">
			  
			</div>
		  </div>
		</div>
		<!-- task validation block end ------------------>
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
		  <button type="button" class="btn btn-info" data-dismiss="modal" onclick="location.href='../../index.php';">Всі завдання</button>
		  <button type="button" class="btn btn-danger" data-dismiss="modal" onclick='history.go(1);'>Закрити</button>
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
	<!-- Initialize checkboxpicker -->
	$(':checkbox').checkboxpicker();
});

  <!-- Initialize highlight -->
  hljs.initHighlightingOnLoad();

</script>
	
</body>
  
<?php

//show completed window on 100%:
if($_SESSION["vr_percent"] == 100){
  //show completed screen:
  echo("<script>$('#myModal').modal('show');</script>");
}

//destory session vars with validation results:
$_SESSION["vr_percent"] = "0";

if(isset($_SESSION["vr_percent"])){
  if($b_do_debug){
    echo("<pre>");
    var_dump($_SESSION);
    echo("</pre>");
  }
}
?>

</html>