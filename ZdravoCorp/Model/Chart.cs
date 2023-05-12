using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.Users;

namespace ZdravoCorp.Model
{
    internal class Chart
    {
        private User patient;
        private double height;
        private double weight;
        private List<string> diseases;
        private List<string> allergies; 
        private List<string> treatments; //Develop into class.

        public Chart(User patient)
        {
            this.patient = patient;
        }
        
        public User GetPatient() { return patient; }
        public double GetHeight() { return height; }
        public double GetWeight() { return weight; }
        public List<string> GetDiseases() {  return diseases; }
        public List <string> GetAllergies() {  return allergies; }
        public List<string> GetTreatments() { return treatments; }
        public string GetChartFilename() { return $"{patient.GetId()}{patient.GetName()}{patient.GetSurname()}"; }

        public void SetHeight(double height) { this.height = height; }
        public void SetWeight(double weight) { this.weight = weight; }
        public void SetDiseases(List<string> diseases) {  this.diseases = diseases; }
        public void SetAllergies(List<string> allergies) { this.allergies = allergies; }
        public void SetTreatments(List<string> treatments) { this.treatments = treatments; }
        
        public void AddNewDisease(string disease) { diseases.Add(disease); }
        public void AddNewAllergy(string allergy) { allergies.Add(allergy); }
        public void AddNewTreatment(string treatment) { treatments.Add(treatment); }

    }
}
