<?php
session_start();
//utf8 support:
header('Content-Type: text/html; charset=utf-8');

header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");

require_once("main_config.php");
require_once("task_core.php");
require_once("validator_be.php");

?>
<html>
  <head>
    <!-- title -->
    <title>Перевірка:</title>
    <?php include_once("head_includes.php"); ?>
 </head>
 <body>
  <div class="container">
    <!-- menu stat: -->
	<div>
	 <h4 class='back_to_task'><a onclick="window.location = '<?php echo(_get_task_url()); ?>';" href="#">&#8592; Повернутися до завдання</a></h4>
	</div>
    <!-- menu end: -->
   <div class="jumbotron task_jumbotron_height_fix">
    <h2 class=''>Перевірка програми:</h2>
    <hr>
    <div class="lead lead-top-fix">
	  <?php 
	    _validate_uploaded_app(); 
	  ?>
    </div>
	
   </div>
  </div> 
  
<?php
if($_SESSION["b_debug"]){
  echo("<pre>");
  var_dump($_SESSION);
  echo("</pre>");
}
?>
  
 </body>
</html>