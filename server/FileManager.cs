using System;
using System.Collections.Generic;
using System.Text;
using SharedProject;

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
    }
}
