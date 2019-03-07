<?php
//https://stackoverflow.com/questions/8612190/array-of-php-objects
class cls_Task{
  public $s_title = '';
  public $s_id = '';
  public $s_description = '';
  public $s_learn_url = "";
  public $s_youtube_url = "";
  public $s_discuss_url = "";
  public $oa_properties = array();
  public $oa_steps = array();
  function _add_property($s_p_name, $s_p_title, $s_p_master_value){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_name = $s_p_name;
	$cls_NewP->s_title = $s_p_title;
	$cls_NewP->s_master_value = $s_p_master_value;
	$cls_NewP->s_type = "";	
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_object_creator($s_instruction, $s_type_obj){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_name = "<div class='obj_creator'>$s_instruction</div>";
	$cls_NewP->s_title = "<div class='obj_creator'>$s_type_obj</div>";
	$cls_NewP->s_master_value = "";
	$cls_NewP->s_type = "obj_creator";	
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_code($s_instruction, $s_code){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_name = $s_instruction;
	$cls_NewP->s_title = "<div onselectstart='return false'><pre><code class='csharp'>" . $s_code . "</code></pre></div>";
	$cls_NewP->s_master_value = "";
	$cls_NewP->s_type = "code";	
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
  public $b_status = "false";
  public $s_type = "";
  public $b_validated = false;
  //syntax:
  //empty  = property (3 args)
  //code   = C# code  (2 args = instruction + code)
  //can be extended!
}
?>