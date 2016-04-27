using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerMenu.Items
{
    public class HamburgerMenuItem
    {
        public string Icon { get; set; }
        public string Text { get; set; }
        public Type TargetFrame { get; set; }
    }
}
