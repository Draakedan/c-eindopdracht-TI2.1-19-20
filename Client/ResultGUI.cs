using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ResultGUI : Form
    {
        private GUIData gui;
        public ResultGUI()
        {
            gui = GUIData.getInstance();
            InitializeComponent();
            lbl_chosenData.Text = gui.day + "\n" + gui.time;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
