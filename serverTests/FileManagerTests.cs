using Microsoft.VisualStudio.TestTools.UnitTesting;
using server;
using System;
using System.Collections.Generic;
using System.Text;
using SharedProject;

namespace server.Tests
{
    [TestClass()]
    public class FileManagerTests
    {
        [TestMethod()]
        public void CheckPossibilityAppointmentTest_appointemntIsNotPossible_returnFalse()
        {
            FileManager manager = new FileManager();
            Appointment appointment = new Appointment();
            appointment.day = "1-1-2019";
            appointment.time = "00:00";

            var result = manager.CheckPossibilityAppointment(appointment);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void checkPossibilityAppointmentTest_appointemntIsPossible_returnTrue()
        {
            FileManager manager = new FileManager();
            Appointment appointment = new Appointment();
            appointment.day = "5-10-2019";
            appointment.time = "10:00";

            var result = manager.CheckPossibilityAppointment(appointment);

            Assert.IsTrue(result);
        }
    }
}