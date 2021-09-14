using System;
using AppointmentModule;
using UserModule;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientModule
{
    class Patient : User , Appointment
    {
        string gender, address;

        public void GetData() { }
        public void AddVisitData() { }
        public void AddAppointment() { }

        public void CancelAppointment()
        {
            throw new NotImplementedException();
        }
    }
}
