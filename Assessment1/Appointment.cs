using System;
using PatientModule;
using PhysicianModule;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentModule
{
    interface Appointment
    {
        void AddAppointment();
        void CancelAppointment();
    }
}
