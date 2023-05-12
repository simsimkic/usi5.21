using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.Model;
using Newtonsoft.Json;

namespace ZdravoCorp.Repository
{
    class AppointmentRepository
    {

        private Dictionary<int, List<Appointment>> appointments = new Dictionary<int, List<Appointment>>();

        private bool IsAvailable(int id, DateTime start, DateTime end)
        {
            if (appointments.ContainsKey(id))
            {
                foreach (var appointment in appointments[id])
                {
                    if (appointment.isOverlapping(id, start, end))
                    {
                        return false;
                    }
                }
            }
            else
            {
                foreach (var doctorAppointments in appointments.Values.ToList())
                {
                    foreach (var doctorAppointment in doctorAppointments)
                    {
                        if (doctorAppointment.isOverlapping(id, start, end))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public bool MakeAppointment(int doctorId, int patientId, DateTime startTime, DateTime endTime)
        {
            bool isDoctorAvailable = this.IsAvailable(doctorId, startTime, endTime);
            bool isPatientAvailable = this.IsAvailable(patientId, startTime, endTime);
            if (isDoctorAvailable && isPatientAvailable)
            {

                if (appointments.ContainsKey(doctorId))
                {
                    appointments[doctorId].Add(new Appointment(doctorId, patientId, startTime, endTime));
                }
                else
                {
                    List<Appointment> l = new List<Appointment>
                    {
                        new Appointment(doctorId, patientId, startTime, endTime)
                    };
                    appointments.Add(doctorId, l);
                }
                return true;
            }
            return false;
        }
    }
}
