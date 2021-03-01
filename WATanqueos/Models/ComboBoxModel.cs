using System;
using System.Collections.Generic;
using System.Text;

namespace WATanqueos.Models
{
    public class ComboBoxModel
    {
        public string DisplayMember { get; set; }
        public object ValueMember { get; set; }

        public override string ToString()
        {
            return DisplayMember;
        }
    }
}
