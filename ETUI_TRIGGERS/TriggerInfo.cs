using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETUI_TRIGGERS
{
    public class TriggerInfo
    {
        public FormTrigger obj;
        public String Name;
        public int Type;
        public String Operation;

        public TriggerInfo(FormTrigger obj,String Name)
        {
            this.obj = obj;
            this.Name = Name;
        }

        public TriggerInfo()
        {

        }

        public TriggerInfo(FormTrigger obj, String Name,int Type,String Operation)
        {
            this.obj = obj;
            this.Name = Name;
            this.Type = Type;
            this.Operation = Operation;
        }

        public TriggerInfo(FormTrigger obj)
        {
            this.obj = obj;
        }

        public TriggerInfo(FormTrigger obj,String Name,int Type)
        {
            this.obj = obj;
            this.Name = Name;
            this.Type = Type;
        }
        
       
    }
}
