using System;
using System.Collections.Generic;
using System.Text;
namespace TaskCreator
{
    class cls_Task
    {
        public string s_title = "";
        public string s_id = "";
        public string s_description = "";
        public string s_block_properties_sharp_code = "";  //properties validated in code.txt
        public string s_block_properties_php_code = "";  //properties validated in code.txt
        public string s_block_steps = "";       //steps in task.php

        public string s_fp = "";
        List<cls_v_Property> lst_Properties = new List<cls_v_Property>();
    }
    class cls_v_Property
    {
        public string s_object = "";
        public string s_property = "";
        public string s_eng_description = "";
        public string s_ua_description = "";
    }
}
