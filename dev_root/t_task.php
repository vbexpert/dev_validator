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
    <!-- utf8 support: -->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
	<!-- jq CDN (bootsrtrap reqired): -->
	<script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha256-/SIrNqv8h6QGKDuNoLGA4iret+kyesCkHGzVUUV0shc=" crossorigin="anonymous"></script>
    <!-- tether	CDN (bootsrtrap reqired): -->
	<script src="https://npmcdn.com/tether@1.2.4/dist/js/tether.min.js"></script>
    <script src="https://npmcdn.com/bootstrap@4.0.0-alpha.5/dist/js/bootstrap.min.js"></script>
	<!-- bootstrap CDN: -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.5/css/bootstrap.min.css" integrity="sha384-AysaV+vQoT3kOAXZkl02PThvDr8HYKPZhNT5h/CXfBThSRXQ6jW5DO2ekP5ViFdi" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.5/js/bootstrap.min.js" integrity="sha384-BLiI7JTZm+JWlgKa0M0kGRpJbF2J8q+qreVrKBC47e3K6BW78kGLrCkeRX6I9RoK" crossorigin="anonymous"></script>
    <!-- favicon: -->
	<link rel="icon" href="favicon.ico?v=2" />
	<!-- external CSS: -->
    <link rel="stylesheet" type="text/css" href="../../_css/global.css">
</head>
<body>
  <div class="container">
    <div class="starter-template">
    <!-- header info block start: -------------------------------------------------------------------------------->
    <?php
      //include_once("../../header.php");
    ?>
    <!-- header info block end: ---------------------------------------------------------------------------------->
    <div class="jumbotron task_jumbotron_height_fix">
      <!-- task info block start --------------------------------------------------------------------------------->
      <h2 class=''><a href = "../../index.php">Назад до Індексу Завдань</a></h2>
      <hr>
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
        <caption class='app_specs'>Специфікація програми:</caption>
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
			  echo("<td><input type='checkbox' class='form-check-input'></td>");
			echo("</tr>");
          }
		  ?>
        </table>
        <div class="row pic-centered">
          <img src="target_form.png">
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
        <h2 class=''>Перевірка:</h2>
          <!-- uploader start -->
          <form id='upload_file' action="..\..\validator_fe.php" method="post" enctype="multipart/form-data">
            Оберіть файл програми, для валідації:
            <label class="btn btn-success btn-browse" for="fileToUpload">
            <input id="fileToUpload" name="fileToUpload" type="file" style="display:none;">
              Обрати файл
            </label>
			<!-- uploader end -->
		 <input type="hidden" name="codefile" value="<?php echo($cls_Task->s_id) ?>"><!-- task id -->
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
	</script>
  </body>
</html>