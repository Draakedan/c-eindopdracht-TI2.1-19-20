using System;
using System.Collections.Generic;
using System.Text;
using SharedProject;
using System.IO;
using Newtonsoft.Json;

namespace server
{
    public class FileManager
    {
        private DayData PossibleTimes;
        private List<Appointment> appointments;

        public FileManager()
        {
            appointments = new List<Appointment>();
            LoadAvailableDates();
            LoadAppointmentList();
        }
       // TODO: make method async/await
        private void LoadAvailableDates()
        {
            string filename = "C:/Users/LENOVO/Desktop/technishe informatica files/2.1 2019-2020/C#/EindOpdracht/code/availableTimes.txt";
            var stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(stream);

            string jsonData = reader.ReadToEnd();
            reader.Close();
            stream.Close();

            PossibleTimes = JsonConvert.DeserializeObject<DayData>(jsonData);
        }

        private void LoadAppointmentList()
        {
            string filename = "C:/Users/LENOVO/Desktop/technishe informatica files/2.1 2019-2020/C#/EindOpdracht/code/appointments.txt";
            var stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(stream);
            string jsonData;
            while (!reader.EndOfStream)
            {
                jsonData = reader.ReadLine();
                appointments.Add(JsonConvert.DeserializeObject<Appointment>(jsonData));
            }
            reader.Close();
            stream.Close();

        }

        public bool CheckPossibilityAppointment(Appointment appointment)
        {
            bool isPossible = false;
            TimeData timeData = new TimeData();
            if (PossibleTimes == null)
                return false;
            foreach (TimeData data in PossibleTimes.times)
            {
                if (appointment.day == data.day)
                {
                    timeData = data;
                    break;
                }
            }

            isPossible = timeData.times.Contains(appointment.time);

            return isPossible;
        }

        public void SaveAppointment(Appointment appointment)
        {
            string filename = "C:/Users/LENOVO/Desktop/technishe informatica files/2.1 2019-2020/C#/EindOpdracht/code/appointments.txt";
            appointments.Add(appointment);

            var stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(stream);
            writer.WriteLine(appointment.ToJSONString());
            writer.Flush();
            writer.Close();
            stream.Close();
        }

        public void UpdateAvailableDates(Appointment appointment)
        {
            TimeData data = new TimeData();
            foreach (TimeData day in PossibleTimes.times)
            {
                if (day.day == appointment.day)
                {
                    data = day;
                    break;
                }
            }

            if (data.times.Contains(appointment.time))
            {
                data.times.Remove(appointment.time);
                if (data.times.Count == 0)
                    PossibleTimes.times.Remove(data);
            }

            string filename = "C:/Users/LENOVO/Desktop/technishe informatica files/2.1 2019-2020/C#/EindOpdracht/code/availableTimes.txt";

            var stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(stream);
            writer.Write(PossibleTimes.ToJSONString());
            writer.Flush();
            writer.Close();
            stream.Close();
        }
    }
}
