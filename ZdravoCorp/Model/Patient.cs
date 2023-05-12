using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.Users;

namespace ZdravoCorp.Model
{
    internal class Patient: User
    {
        private bool isBlocked;
        public Patient()
        {
            this.isBlocked = false;
        }



        public bool MakeAppointment(int doctorId, DateTime start)
        {
            DateTime end = DateTime.MinValue.AddMinutes(15);
            if(this.isBlocked) return false;
            // Check if doctor is available from start to start + 15min
            //bool isAvailable =  AppointmentsRepository.CheckAvailability(doctorId, start,end);
            //if (isAvailable)
            //{
                
            //}

            throw new NotImplementedException();
        }
    }
}
