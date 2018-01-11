<?php
$b_is_local = true;
$s_domain = "https://c-validator.com:";
$b_use_access_wall = true;   //login required

if($b_is_local == true){
  $s_domain = "127.0.0.1";
  $b_use_access_wall = false;
}

$s_web_root = $_SERVER['DOCUMENT_ROOT'].DIRECTORY_SEPARATOR;
$s_v_app_root = $s_web_root."validator".DIRECTORY_SEPARATOR;
$b_do_debug = false;		     //do debug global

if($b_do_debug){
  error_reporting(E_ALL);
  ini_set('display_errors', 1);
}
?>