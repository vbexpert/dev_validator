<?php
//https://stackoverflow.com/questions/8612190/array-of-php-objects
class cls_Task{
  public $s_title = '';
  public $s_id = '';
  public $s_description = '';
  public $s_youtube_url = "";
  public $s_discuss_url = "";
  public $oa_properties = array();
  public $oa_steps = array();
  function _add_property($s_p_name, $s_p_title, $s_p_master_value){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_name = $s_p_name;
	$cls_NewP->s_title = $s_p_title;
	$cls_NewP->s_master_value = $s_p_master_value;
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_step($s_step_desc){
	array_push($this->oa_steps, $s_step_desc);
  }
}
class cls_Property{
  public $s_name = "";
  public $s_title = "";
  public $s_master_value = "";
}
?>