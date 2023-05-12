using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.Model;
using Newtonsoft.Json;

namespace ZdravoCorp.Repository
{
    internal class PatientRepository
    {
        private List<Patient> patients = new List<Patient>();
        public PatientRepository() { 
            // Read patients from .json file
        }
        public List<Patient> GetAllPatients()
        {
            return this.patients;
        }

        public Patient? GetPatient(int id)
        {
            foreach (Patient patient in this.patients)
            {
                if (id == patient.GetId())
                {
                    return patient;
                }
            }

            return null;
        }

        public bool AddPatient(Patient p)
        {
            // needs to update .json file
            throw new NotImplementedException();
        }

        public bool DeletePatient(int id)
        {
            // needs to update .json file
            throw new NotImplementedException();
        }
    }
}
