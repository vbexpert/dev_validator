<?php
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
header('Content-Type: text/html; charset=utf-8');
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");
?>
<html>
  <head>
    <!-- title -->
    <title>Завдання '<?php echo($cls_Task->s_title); ?>'</title>
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
	  
      <h1 class="">Завдання '<?php echo($cls_Task->s_title); ?>':</h1>
      <h3 class=""><?php echo($cls_Task->s_description); ?></h3>
      <hr>
	  <?php
	    foreach ($cls_Task->oa_steps as $s_step){
		  echo("<p class='lead lead-top-fix'>".$s_step."</p>");
		}
	  ?>
      <hr>
      <table class="table table-striped table-condensed">
        <caption class='app_specs' align="bottom">Специфікація програми:</caption>
          <thead>
            <tr>
              <th>Property:</th>
              <th>Властивість:</th>
              <th>Значення:</th>
              <th>Стан:</th>
            </tr>
          </thead>
		  <?php
		  //var_dump($cls_Task->oa_properties);
		  foreach ($cls_Task->oa_properties as $cls_property){
			echo("<tr>");
			  echo("<td>".$cls_property->s_name."</td>");
			  echo("<td>".$cls_property->s_title."</td>");
			  echo("<td>".$cls_property->s_master_value."</td>");
			  switch ($cls_property->s_type) {
				case "":
					echo("<td><input type='checkbox' class='form-check-input big-checkbox'></td>");
					break;
				case "obj_creator":
					echo("<td></td>");
					break;					
				case "code":
					echo("<td></td>");
					break;
			  }
			echo("</tr>");
          }
		  ?>
        </table>
        <div class="row f_img_holder">
          <img class='f_img' src="target_form.png" />
        </div>
		
		<!-- footer start ------------------------------->
		
	    <!-- help block start -->
         <div style="text-align: center;"> 
           <a class="btn btn-info " href="https://learn.ztu.edu.ua" role="button" target="_blank">Почитати на порталі ЖДТУ</a>
           <a class="btn btn-danger" href="<?php echo($cls_Task->s_youtube_url); ?>" role="button" target="_blank">Подивитись відеоурок</a>
           <a class="btn btn-warning" href="<?php echo($cls_Task->s_discuss_url) ?>" role="button" target="_blank">Обговорити у спільноті</a>
         </div>
	    <!-- help block end -->
		
		<hr>

        <!-- task validation block start ---------------->
        <h2>Перевірка:</h2>
		  <div class="row">
          <!-- uploader start -->
          <form id='upload_file' class='upload_file' action="..\..\validator_fe.php" method="post" enctype="multipart/form-data">
			<label class="btn btn-primary btn-md">
				Оберіть файл програми, для валідації:<input id="fileToUpload" name="fileToUpload" type="file" hidden />
			</label>
		    <input type="hidden" name="codefile" value="<?php echo($cls_Task->s_id) ?>"/><!-- task id -->
		  </div>
        </form>
		<!-- task validation block end ------------------>
		
		<!-- footer end --------------------------------->
		
		</div>
      </div>
    </div>
	
    <script>
	$('#fileToUpload').change(function(){ 
		$('#upload_file').submit();
	});
	<!-- Initialize highlight -->
	hljs.initHighlightingOnLoad();
	</script>
	
  </body>
</html>