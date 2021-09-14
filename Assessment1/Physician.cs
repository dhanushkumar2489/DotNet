using System;
using UserModule;
using AppointmentModule;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicianModule
{
    class Physician :User , Appointment
    {
        public void AddAppointment()
        {
            throw new NotImplementedException();
        }

        public void CancelAppointment()
        {
            throw new NotImplementedException();
        }

        public void GetAppointments() { }
        public void ViewInbox() { }
    }
}
