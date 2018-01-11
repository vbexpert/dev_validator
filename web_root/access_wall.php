<?php
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);
//--------------------------------------------------->
//init wordpress:
define('WP_USE_THEMES', false);
global $wp, $wp_query, $wp_the_query, $wp_rewrite, $wp_did_header;
require("..".DIRECTORY_SEPARATOR."wp-load.php");
//--------------------------------------------------->
//wp access wall:
if ( !is_user_logged_in() ) {
   auth_redirect();
}
//--------------------------------------------------->
//get logged in user details:
$current_user = wp_get_current_user();
if(!($current_user instanceof WP_User)){
  auth_redirect();
  exit;
}
else{
  echo 'Username: ' . $current_user->user_login . '<br />';
  echo 'User email: ' . $current_user->user_email . '<br />';
  echo 'User first name: ' . $current_user->user_firstname . '<br />';
  echo 'User last name: ' . $current_user->user_lastname . '<br />';
  echo 'User display name: ' . $current_user->display_name . '<br />';
  echo 'User ID: ' . $current_user->ID . '<br />';
  $s_url_avatar = get_avatar_url($current_user->user_email);
  echo "<img src='$s_url_avatar' />";
}
//--------------------------------------------------->
?>