<?php
//--------------------------------------------------->
//init wordpress:
define('WP_USE_THEMES', false);
global $wp, $wp_query, $wp_the_query, $wp_rewrite, $wp_did_header;
require($s_web_root."wp-load.php");
//--------------------------------------------------->
//wp access wall:
if ( !is_user_logged_in() ) {
   auth_redirect();
   exit;
}
//--------------------------------------------------->
//get logged in user details:
$current_user = wp_get_current_user();
if(!($current_user instanceof WP_User)){
  auth_redirect();
  exit;
}
else{
  if($current_user->user_firstname == ""){
	//use email both times:
    $_SESSION["s_user_name"] = $current_user->user_email;
    $_SESSION["s_user_email"] = $current_user->user_email;
  }
  else{
    $_SESSION["s_user_name"] = $current_user->display_name;
    $_SESSION["s_user_email"] = $current_user->user_email;
  }
  //echo 'Username: ' . $current_user->user_login . '<br />';
  //echo 'User email: ' . $current_user->user_email . '<br />';
  //echo 'User first name: ' . $current_user->user_firstname . '<br />';
  //echo 'User last name: ' . $current_user->user_lastname . '<br />';
  //echo 'User display name: ' . $current_user->display_name . '<br />';
  //echo 'User ID: ' . $current_user->ID . '<br />';
  //$s_url_avatar = get_avatar_url($current_user->user_email);
  //echo "<img src='$s_url_avatar' />";
}
//--------------------------------------------------->
?>