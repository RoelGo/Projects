using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySorting
{
    public partial class View : Form
    {
        public View( )
        {
            InitializeComponent();
            richTextBox1.Text = "Start";
            richTextBox1.AppendText("\r\n govvgfsdfsdgfsdk");
        }

        public void UpdateText(String input)
        {
            richTextBox1.AppendText("\r\n " + input);
            richTextBox1.Update();
        }
    }
}
