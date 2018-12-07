using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Button_ToolTip
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button1, "Button");
            
        }
    }
}
