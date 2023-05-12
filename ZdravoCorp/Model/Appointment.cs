using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZdravoCorp.Model
{
    class Appointment
    {
        private int doctorId;
        private int patientId;
        private DateTime startTime;
        private DateTime endTime;

        public Appointment(int doctorId, int patientId, DateTime startTime, DateTime endTime)
        {
            this.doctorId = doctorId;
            this.patientId = patientId;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public bool isOverlapping(int id, DateTime startTime, DateTime endTime)
        {
            return (this.doctorId == id || this.patientId == id) &&
                   (this.startTime < endTime || this.endTime > startTime);
        }
    }
}
