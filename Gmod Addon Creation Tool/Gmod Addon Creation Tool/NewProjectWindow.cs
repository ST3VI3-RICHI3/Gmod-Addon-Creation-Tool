using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmod_Addon_Creation_Tool
{
    public partial class NewProjectWindow : Form
    {
        string[] ReturnValue;
        public NewProjectWindow()
        {
            InitializeComponent();
        }

        private void NewProjectWindow_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ReturnValue[1] = "NULL";
            Close();
        }
    }
}
