<?php
$s_servername = "localhost";
$s_username = "php_script_user";
$s_password = "php_script_user_long_password_8465!";
$s_db_name = "c-validator";

$obj_connection = new mysqli($s_servername, $s_username, $s_password, $s_db_name);
if ($obj_connection->connect_error) {
  die("mysql Connection failed");
}
//echo("ok!");

//---->
//$sql = "INSERT INTO v_stats (dt_datetime,s_user_email,i_score,s_task_id,s_user_name) VALUES(NOW(), 'cargo-base@yandex.ru', 100, 'test task','Yurii');";
//$result = $obj_connection->query($sql);

//$result = $obj_connection->query($sql);
//if ($result->num_rows > 0) {
//    while($row = $result->fetch_assoc()) {
//        echo "id: " . $row["id"]. " - Name: " . $row["firstname"]. " " . $row["lastname"]. "<br>";
//    }
//} else {
//    echo "0 results";
//}
//---->

//$obj_connection->close();

?>