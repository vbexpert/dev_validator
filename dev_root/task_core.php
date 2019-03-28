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
	$cls_NewP->s_type = "property";	
	$cls_NewP->b_must_validate = true;
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_object_creator($s_instruction, $s_type_obj){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_name = $s_instruction;
	$cls_NewP->s_title = $s_type_obj;
	$cls_NewP->s_master_value = "";
	$cls_NewP->s_type = "obj_creator";	
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_code_validated($s_instruction, $s_code){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_name = $s_instruction;
	$cls_NewP->s_master_value = $s_code;
	$cls_NewP->s_type = "code_validated";	
	$cls_NewP->b_must_validate = true;
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_code_non_validated($s_instruction, $s_code){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_name = $s_instruction;
	$cls_NewP->s_master_value = $s_code;
	$cls_NewP->s_type = "code_non_validated";	
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_step($s_step_desc){
	array_push($this->oa_steps, $s_step_desc);
  }
  function _add_screen($s_title,$s_img_ft){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_type = "screen";	
	$cls_NewP->s_title = $s_title;
	$cls_NewP->s_master_value = $s_img_ft;
	array_push($this->oa_properties, $cls_NewP);
  }
  function _add_youtube_link($s_text,$s_url){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_type = "youtube";
	$cls_NewP->s_title = $s_text;
	$cls_NewP->s_master_value = $s_url;
	array_push($this->oa_properties, $cls_NewP);
  }
  function _block_end(){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_type = "block_end";
	array_push($this->oa_properties, $cls_NewP);
  }
  function _block_start($s_block_title, $img_name){
    $cls_NewP = new cls_Property();
	$cls_NewP->s_type = "block_start";
	$cls_NewP->s_title = $img_name;
	$cls_NewP->s_master_value = $s_block_title;
	array_push($this->oa_properties, $cls_NewP);
  }
}
class cls_Property{
  public $s_name = "";
  public $s_title = "";
  public $s_master_value = "";
  public $b_status = false;
  public $s_type = "";
  public $b_validated = false;
  public $b_must_validate = false;
  //syntax:
  //empty  = property (3 args)
  //code   = C# code  (2 args = instruction + code)
  //can be extended!
}
?>