using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SharedProject;
using Newtonsoft.Json;

namespace Client
{
    
    public partial class DateSelectGUI : Form
    {
        private TcpClient client;
        private DayData days;
        private GUIData gui;
        public DateSelectGUI()
        {
            client = new TcpClient("127.0.0.1", 1440);
            gui = GUIData.getInstance();
            InitializeComponent();
            getAvailableDates();
            lbl_username.Text = gui.username;
            
        }

        private void getAvailableDates()
        {
            string JsonData = SharedIOMehtods.ReadTextMessage(client);
            days = JsonConvert.DeserializeObject<DayData>(JsonData);
            cbx_day.Items.Clear();
            foreach (TimeData time in days.times)
                cbx_day.Items.Add(time.day);
            cbx_day.SelectedIndex = 0;
            cbx_time.Items.Clear();
            foreach (string timestring in days.times[0].times)
                cbx_time.Items.Add(timestring);
            cbx_time.SelectedIndex = 0;
        }

        private void cbx_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            gui.day = (string)cbx_day.SelectedItem;
            int i = cbx_day.SelectedIndex;
            TimeData data = days.times[i];
            cbx_time.Items.Clear();

            foreach (string timestring in data.times)
                cbx_time.Items.Add(timestring);
            cbx_time.SelectedIndex = 0;
        }

        private void cbx_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            gui.time = (string)cbx_time.SelectedItem;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            sendAppointmentToServer();
            string reply = getreply();
            if (reply == "OK")
            {
                client.Close();
                Close();
            }
            else
            {
                lbl_result.Visible = true;
                getAvailableDates();
            }
        }

        private void sendAppointmentToServer()
        {
            Appointment appointment = new Appointment();
            appointment.setAllData(gui.getAllData());
            SharedIOMehtods.WriteTextMessage(client, appointment.ToJSONString());
        }

        private string getreply()
        {
            return SharedIOMehtods.ReadTextMessage(client);
        }

        private void displayErrorMessage()
        {
            lbl_result.Visible = true;
            Application.DoEvents();
        }
    }
}
