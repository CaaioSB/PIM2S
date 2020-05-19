using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHERCHAIN_COMMON
{
    internal class Employee
    {
        private int _employeeId;
        private string _email;
        private string _words;
        private string _wordsLanguage;
        private string _country;
        private string _streetLine;
        private string _city;
        private string _region;
        private string _postCode;
        private string _mobileNumber;
        private string _CPF;
        private string _RG;
        private char _gender;
        private string _firstName;
        private string _lastName;
        private DateTime _dataNascimento;

        public int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string Email { get => _email; set => _email = value; }
        public string Words { get => _words; set => _words = value; }
        public string WordsLanguage { get => _wordsLanguage; set => _wordsLanguage = value; }
        public string Country { get => _country; set => _country = value; }
        public string StreetLine { get => _streetLine; set => _streetLine = value; }
        public string City { get => _city; set => _city = value; }
        public string Region { get => _region; set => _region = value; }
        public string PostCode { get => _postCode; set => _postCode = value; }
        public string MobileNumber { get => _mobileNumber; set => _mobileNumber = value; }
        public string CPF { get => _CPF; set => _CPF = value; }
        public string RG { get => _RG; set => _RG = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }

        public Employee ObterPorId() { return new Employee(); }
        public Employee ObterPorEmail() { return new Employee(); }
        public Employee ObterPorCPF() { return new Employee(); }
        public Employee ObterPorRG() { return new Employee(); }
        public List<Employee> ObterTodos() { return new List<Employee>(); }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
