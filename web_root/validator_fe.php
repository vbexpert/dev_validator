<?php
session_start();
//utf8 support:
header('Content-Type: text/html; charset=utf-8');

header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");

require("main_config.php");
require("task_core.php");
require("validator_be.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Перевірка:</title>
	<?php
	  require("head_meta_tags.php");
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
	
   </div>
  </div> 
  
<?php
if($b_do_debug){
  echo("<pre>");
  var_dump($_SESSION);
  echo("</pre>");
}
?>
  
 </body>
</html>