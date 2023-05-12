using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZdravoCorp.Users
{

    enum Gender
    {
        Male,
        Female,
        Other
    }
    enum Role
    {
        Doctor,
        Nurse,
        Patient,
        Admin
    }
    internal class User
    {
        private int id;
        private string name;
        private string surname;
        private string username;
        private string password;
        private DateTime birthDate;
        private Gender gender;
        private Role role;

        public User() { }

        public User(int id, string name, string surname, string username, string password, DateTime birthDate, Gender gender, Role role)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.birthDate = birthDate;
            this.gender = gender;
            this.role = role;
        }

        public int GetId() { return id; }
        public string GetName() { return name; }
        public string GetSurname() {  return surname; }
        public string GetUsername() { return username; }
        public string GetPassword() { return password; } 
        public DateTime GetBirthDate() { return birthDate; }
        public Gender GetGender() { return gender; }
        public Role GetRole() { return role; }
        public void SetId(int id) { this.id = id; }
        public void SetName(string name) {  this.name = name; }
        public void SetSurname(string surname) { this.surname = surname; }
        public void SetUsername(string username) { this.username = username; }
        public void SetPassword(string password) {  this.password = password; }
        public void SetBirthDate(DateTime birthDate) { this.birthDate = birthDate; }
        public void SetGender(Gender gender) { this.gender = gender; }
        public void SetRole(Role role) { this.role = role;}
    }
}
