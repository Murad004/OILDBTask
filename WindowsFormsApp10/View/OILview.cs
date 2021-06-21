using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp10.Model;

namespace WindowsFormsApp10.View
{
    public partial class OILview : Form
    {
        public OILview()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> OrderButtonClick { get; set; }
        public string PriceText { get => PriceTxtBox.Text; set => PriceTxtBox.Text = value; }

        public List<OIL> OILS
        {
            set
            {
                OILSListBox.DataSource = null;
                OILSListBox.DataSource = value;
            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OrderButtonClick.Invoke(sender, e);
        }

        
    }
}
