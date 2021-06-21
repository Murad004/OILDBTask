using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp10.Model;

namespace WindowsFormsApp10.View
{
    interface IOILView
    {
        EventHandler<EventArgs> OrderButtonClick { get; set; }
        string PriceText { get; set; }
        List<OIL> OILS { set; }
    }
}
