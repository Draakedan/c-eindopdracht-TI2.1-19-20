using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SharedProject;
using Newtonsoft.Json;

namespace server
{
    public class ServerMain
    {
        private static FileManager manager;
        static void Main(string[] args)
        {
            manager = new FileManager();
            IPAddress localhost;
            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);

            if (!ipIsOk)
            {
                Console.WriteLine("Ip address can't be parsed.");
                Environment.Exit(1);
            }

            TcpListener listener = new System.Net.Sockets.TcpListener(localhost, 1440);
            listener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for connection");

                TcpClient client = listener.AcceptTcpClient();

                Thread thread = new Thread(HandleClientThread);
                thread.Start(client);
            }
        }

        static void HandleClientThread(object obj)
        {
            bool isFinished = false;
            TcpClient client = obj as TcpClient;
            while (!isFinished)
            {
                sendDayData(client);
                Appointment appointment = receiveAppointmentData(client);
                if (manager.CheckPossibilityAppointment(appointment))
                {
                    SharedIOMehtods.WriteTextMessage(client, "OK");
                    manager.UpdateAvailableDates(appointment);
                    manager.SaveAppointment(appointment);
                    isFinished = true;
                }
                else
                    SharedIOMehtods.WriteTextMessage(client, "Not possible");
            }
            client.Close();
            Console.WriteLine("Connection closed");
        }

        private static void sendDayData(TcpClient client)
        {
            string day = manager.PossibleTimes.ToJSONString();
            SharedIOMehtods.WriteTextMessage(client, day);
        }

        private static Appointment receiveAppointmentData(TcpClient client)
        {
            string appointmentJSON = SharedIOMehtods.ReadTextMessage(client);
            Appointment appointment = JsonConvert.DeserializeObject<Appointment>(appointmentJSON);
            return appointment;
        }
    }
}
