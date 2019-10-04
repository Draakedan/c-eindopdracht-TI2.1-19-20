using System;
using System.Collections.Generic;
using System.Text;
using SharedProject;
using System.IO;

namespace server
{
    class FileManager
    {
        private DayData PossibleTimes;
        private List<Appointment> appointments;

        public FileManager()
        {
            appointments = new List<Appointment>();
        }

        public void SaveAppointment(Appointment appointment)
        {
            string filename = System.Environment.CurrentDirectory + "/appointments.txt";
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

            string filename = System.Environment.CurrentDirectory + "/availableTimes.txt";

            var stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(stream);
            writer.Write(PossibleTimes.ToJSONString());
            writer.Flush();
            writer.Close();
            stream.Close();
        }
    }
}
