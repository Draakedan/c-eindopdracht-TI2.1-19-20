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
    public partial class LogInGUI : Form
    {
        private GUIData gui;
        public LogInGUI()
        {
            gui = GUIData.getInstance();
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (tbx_username.Text != "")
            {
                gui.username = tbx_username.Text;
                Close();
            }
        }
    }
}
