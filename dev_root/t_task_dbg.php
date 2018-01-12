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

		  <?php
		  //var_dump($cls_Task->oa_properties);
		  $i_ctr = 0;
		  foreach ($cls_Task->oa_properties as $cls_property){
			//---> patch with session vars:
			if(isset($_SESSION["vr_percent"])){
			  $s_s_title="vr".$i_ctr."_reslt";
			  if($_SESSION[$s_s_title] != ""){
				
			    $cls_property->b_validated = true;
			    //destroy session var:
			    //$_SESSION[$s_s_title] = "";
			  }
			  else{
				$cls_property->b_validated = false;
			  }
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
					  $s_checked = "checked=\"checked\"";
					  echo("true: ".$cls_property->s_title);
					}
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
	
</body>
  
<?php

if($b_do_debug){
  echo("<pre>");
  var_dump($_SESSION);
  echo("</pre>");
}
?>

</html>