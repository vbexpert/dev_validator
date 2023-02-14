<?php
session_start();
require("main_config.php");
//destroy critical session vars manually:
unset($_SESSION["s_user_fn"]);
unset($_SESSION["s_user_email"]);

if($b_do_debug){
  echo("<pre>");
  var_dump($_SESSION);
  echo("</pre>");
}

header('Location: '.$s_domain."/wp-login.php?action=logout");
?>