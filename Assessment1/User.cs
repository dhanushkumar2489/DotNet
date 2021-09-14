using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    enum role
    {
        patient,
        physician,
        nurse,
        admin
    }
    class User
    {
        public string firstName, lastName, DOB, emailId;
        public long phoneNo;
        public int id;

        public void ChangePassword() { }
    }
}
