using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class GUIData
    {
        public string username{get; set;}
        public string day { get; set; }
        public string time { get; set; }

        private static GUIData instance;

        private GUIData()
        { 
        }

        public static GUIData getInstance()
        {
            if (instance == null)
                instance = new GUIData();
            return instance;
        }

        public (string, string, string) getAllData()
        {
            return (username, day, time);
        }
    }
}
