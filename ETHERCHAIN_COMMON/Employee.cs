using caiosb.SqlMaster;
using caiosb.SqlMaster.Command;
using caiosb.Util.Data;
using ETHERCHAIN_COMMON;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    public class Employee
    {
        private int _employeeId;
        private int _archiveId;
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
        private DateTime _dataBirth;

        public int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public int ArchiveId { get => _archiveId; set => _archiveId = value; }
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
        public DateTime DateBirth { get => _dataBirth; set => _dataBirth = value; }

        private Employee obter(SqlDataReader reader) => new Employee
        {
            EmployeeId = UtilConvert.ToInt(reader["EMPLOYEE_ID"]),
            ArchiveId = UtilConvert.ToInt(reader["ARCHIVE_ID"]),
            Email = UtilConvert.ToString(reader["EMAIL"]),
            Words = UtilConvert.ToString(reader["WORDS"]),
            WordsLanguage = UtilConvert.ToString(reader["WORDS_LANGUAGE"]),
            Country = UtilConvert.ToString(reader["COUNTRY"]),
            StreetLine = UtilConvert.ToString(reader["STREET_LINE"]),
            City = UtilConvert.ToString(reader["CITY"]),
            Region = UtilConvert.ToString(reader["REGION"]),
            PostCode = UtilConvert.ToString(reader["POSTCODE"]),
            MobileNumber = UtilConvert.ToString(reader["MOBILE_NUMBER"]),
            CPF = UtilConvert.ToString(reader["CPF"]),
            RG = UtilConvert.ToString(reader["RG"]),
            Gender = UtilConvert.ToChar(reader["GENDER"]),
            FirstName = UtilConvert.ToString(reader["FIRST_NAME"]),
            LastName = UtilConvert.ToString(reader["LAST_NAME"]),
            DateBirth = UtilConvert.ToDateTime(reader["DATE_BIRTH"]),
        };

        public Employee ObterPorId()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Employee");
            objSelect.Where.where("EMPLOYEE_ID", EmployeeId);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Employee employee = null;
            if (reader.Read())
            {
                employee = obter(reader);
            }
            reader.Close();

            return employee;
        }
        public Employee ObterPorEmail()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Employee");
            objSelect.Where.where("EMAIL", Email);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Employee employee = null;
            if (reader.Read())
            {
                employee = obter(reader);
            }
            reader.Close();

            return employee;
        }
        public Employee ObterPorCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Employee");
            objSelect.Where.where("CPF", CPF);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Employee employee = null;
            if (reader.Read())
            {
                employee = obter(reader);
            }
            reader.Close();

            return employee;
        }
        public Employee ObterPorRG()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Employee");
            objSelect.Where.where("RG", RG);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Employee employee = null;
            if (reader.Read())
            {
                employee = obter(reader);
            }
            reader.Close();

            return employee;
        }
        public List<Employee> ObterTodos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Employee");

            List<Employee> employee = new List<Employee>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                employee.Add(obter(reader));
            reader.Close();

            return employee;
        }
        public void Gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("Employee");
            objInsert.Value.val("ARCHIVE_ID", ArchiveId)
                .val("EMAIL", Email)
                .val("CPF", CPF)
                .val("RG", RG)
                .val("WORDS", Words)
                .val("WORDS_LANGUAGE", WordsLanguage)
                .val("GENDER", Gender)
                .val("COUNTRY", Country)
                .val("FIRST_NAME", FirstName)
                .val("LAST_NAME", LastName)
                .val("DATE_BIRTH", DateBirth)
                .val("STREET_LINE", StreetLine)
                .val("CITY", City)
                .val("REGION", Region)
                .val("POSTCODE", PostCode)
                .val("MOBILE_NUMBER", MobileNumber);

            EmployeeId = objInsert.executeWithOutput(App.DatabaseSql);
        }
        public void AlterarPorId()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("Employee");
            objUpdate.Where.where("EMPLOYEE_ID", EmployeeId);
            objUpdate.Value.val("ARCHIVE_ID", ArchiveId)
                .val("EMAIL", Email)
                .val("CPF", CPF)
                .val("RG", RG)
                //.val("WORDS", Words)
                //.val("WORDS_LANGUAGE", WordsLanguage)
                .val("GENDER", Gender)
                .val("COUNTRY", Country)
                .val("FIRST_NAME", FirstName)
                .val("LAST_NAME", LastName)
                .val("DATE_BIRTH", DateBirth)
                .val("STREET_LINE", StreetLine)
                .val("CITY", City)
                .val("REGION", Region)
                .val("POSTCODE", PostCode)
                .val("MOBILE_NUMBER", MobileNumber);

            objUpdate.execute(App.DatabaseSql);
        }
    }
}
