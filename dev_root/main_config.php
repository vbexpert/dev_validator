<?php
$b_is_local = false;
$s_domain = "https://c-validator.com/";
$b_use_access_wall = true;   //login required
$b_do_debug = false;		     //do debug global

if($b_is_local == true){
  $s_domain = "http://127.0.0.1/";
  $b_use_access_wall = false;
  $_SESSION["s_user_name"] = "anonymous";
  $_SESSION["s_user_email"] = "anonymous";
}

$s_web_root = $_SERVER['DOCUMENT_ROOT'].DIRECTORY_SEPARATOR;
$s_v_app_root = $s_web_root."validator".DIRECTORY_SEPARATOR;

if($b_do_debug){
  error_reporting(E_ALL);
  ini_set('display_errors', 1);
}
?>