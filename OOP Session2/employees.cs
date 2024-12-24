using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_Session2
{
    enum SecurityLevel
    {
        guest, Developer, secretary , DBA
    }
    enum Gender
    {
        Male = 1, M = 1, Female = 2  , F = 2
    }
    //public class HiringDate
    //{
    //    public int day { get; set; }
    //    public int month { get; set; }
    //    public int year { get; set; }
    //    public HiringDate(int _day, int _month, int _year)
    //    {

    //        day = _day;
    //        month = _month;
    //        year = _year;
    //    }
    //    public override string ToString()
    //    {
    //        return $" {day}/{month}/{year}";
    //    }
    //}
    internal class employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public int Salary { get; set; }
        public DateTime HireDate { get; private set; } = DateTime.Now;
        public Gender Gender { get; set; }

        public employees(int _id, string _name, Gender _gender, SecurityLevel _securityLevel, int _salary)
        {
            Id = _id;
            Name = _name;
            Gender = _gender;
            SecurityLevel = _securityLevel;
            Salary = _salary;
        }
        public override string ToString()
        {
            return $" id = {Id}\nName = {Name}\nSecurity Level = {SecurityLevel}\nSalary = {Salary:C}\nHire Date ={HireDate}\nGender = {Gender}";
        }
    }
}
