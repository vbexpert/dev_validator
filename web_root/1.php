<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

session_start();

eval("\$_SESSION[\"vrp_count\"] = 3;");
eval("\$_SESSION[\"vr0_reslt\"] = True;");
eval("\$_SESSION[\"vr0_error\"] = \"\";");
eval("\$_SESSION[\"vr0_score\"] = 20;");
eval("\$_SESSION[\"vr1_reslt\"] = True;");
eval("\$_SESSION[\"vr1_error\"] = \"\";");
eval("\$_SESSION[\"vr1_score\"] = 20;");
eval("\$_SESSION[\"vr2_reslt\"] = True;");
eval("\$_SESSION[\"vr2_error\"] = \"\";");
eval("\$_SESSION[\"vr2_score\"] = 20;");
eval("\$_SESSION[\"vr_percent\"] = 100;");

echo("<pre>");
var_dump($_SESSION);
echo("</pre>");
?>