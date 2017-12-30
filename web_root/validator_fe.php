<?php
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
include_once("validator_be.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Перевірка:</title>
	<?php
	  include_once("head_meta_tags.php");
	?>
	<!-- external CSS: -->
    <link rel="stylesheet" type="text/css" href="_css/global.css">
 </head>
 <body>
  <div class="container">
    <!-- menu stat: -->
	<div>
	 <h4 class='back_to_task'><a onclick="window.history.go(-1); return false;" href="#">&#8592; Повернутися до завдання</a></h4>
	</div>
    <!-- menu end: -->
   <div class="jumbotron task_jumbotron_height_fix">
    <h2 class=''>Перевірка програми:</h2>
    <hr>
    <div class="lead lead-top-fix">
	 <?php _validate_uploaded_app(); ?>
    </div>
	
	<div class="progress">
	  <div class="progress-bar progress-bar-success progress-bar-striped" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width:10%">
		40%!
	  </div>
	</div>
	
   </div>
  </div> 
 </body>
</html>