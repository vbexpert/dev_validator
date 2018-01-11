<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

session_start();
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
include_once("main_config.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Графік Успішності:</title>
    <!-- utf8 support: -->
	<?php
	  include_once("head_meta_tags.php");
	?>
	<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
	<!-- external CSS: -->
    <link rel="stylesheet" type="text/css" href="_css/global.css">
	
</head>
 <body>
   <div class="container">
     <div class="starter-template">
       <div class="jumbotron task_jumbotron_height_fix">
	   
       <!-- menu stat: -->
	    <?php
            include_once("nav_menu.php");
        ?>
       <!-- menu end: -->
	   
		 <!-- chart start --------------------------------------------------------------------------------------------->
		 <h2 class=''>Графік Успіху:</h2>
		 <div id="chart_div" style='height:600px;'></div>
         <!-- chart end ----------------------------------------------------------------------------------------------->

		</div>
		
      </div>
    </div>

<script>
google.charts.load('current', {packages: ['corechart', 'line']});
google.charts.setOnLoadCallback(drawBackgroundColor);

function drawBackgroundColor() {
      var data = new google.visualization.DataTable();
	  
	  data.addColumn('number', 'Час');
	  
<?php
//get uniqueue users:
require("db_connect.php");
$sql = "SELECT DISTINCT s_user_email FROM v_stats;"; //where dt_datetime >= DATE_SUB(NOW(),INTERVAL 2 HOUR);
$result = $obj_connection->query($sql);

$ar_dm = array(); //datamatrix

$i_ctr = 0;
if ($result->num_rows > 0){
  while($row = $result->fetch_assoc()){
	//sample mysql code:
    //echo "id: " . $row["id"]. " - Name: " . $row["firstname"]. " " . $row["lastname"]. "<br>";
	$s_u_email = $row["s_user_email"];
	
	//init user array:
	$oa_user = array();
	
	//load data:
	array_push($oa_user,$s_u_email); //push user email firstname
	
	$sql = "SELECT * FROM v_stats WHERE s_user_email = '$s_u_email' ORDER BY i_id";
	$result2 = $obj_connection->query($sql);
	if ($result2->num_rows > 0){
	  while($row = $result2->fetch_assoc()){
	    array_push($oa_user,$row['i_score']);
	  }
	}
	
	//assign to data matrix:
	$ar_dm[$i_ctr] = $oa_user; //add userarray to datamatrix:
	
	echo("data.addColumn('number', '$s_u_email');".PHP_EOL);
	$i_ctr++;
  }
}
?>

	  //data.addColumn('number', 'Юрій');

      data.addRows([
        [0,0,2],
		[1,10,3],
		[2,23,2],
		[3,17,4],
		[4,18,2],
		[5,9,2]
      ]);

      var options = {
        hAxis: {
          title: 'Спроби:'
        },
        vAxis: {
          title: 'Бали:'
        },
        backgroundColor: '#white'
      };

      var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
      chart.draw(data, options);
    }
</script>
	
<br>
<?php
  var_dump($ar_dm);
?>
	
  </body>
</html>