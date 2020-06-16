using caiosb.SqlMaster;
using caiosb.SqlMaster.Command;
using caiosb.SqlMaster.Element.Where;
using caiosb.SqlMaster.Helper;
using caiosb.Util.Data;
using Etherchain.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using uiCSB.Toastr;
using Type = uiCSB.Toastr.Type;

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
        private string _neighborhood;
        private string _region;
        private string _number;
        private string _postCode;
        private string _mobileNumber;
        private string _phoneNumber;
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
        public string Neighborhood { get => _neighborhood; set => _neighborhood = value; }
        public string Region { get => _region; set => _region = value; }
        public string Number { get => _number; set => _number = value; }
        public string PostCode { get => _postCode; set => _postCode = value; }
        public string MobileNumber { get => _mobileNumber; set => _mobileNumber = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string CPF { get => _CPF; set => _CPF = value; }
        public string RG { get => _RG; set => _RG = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateBirth { get => _dataBirth; set => _dataBirth = value; }

        private Employee obter(SqlDataReader reader) => new Employee
        {
            EmployeeId = UtilConvert.ToInt(reader["ID"]),
            ArchiveId = UtilConvert.ToInt(reader["ARCHIVE_ID"]),
            Email = UtilConvert.ToString(reader["EMAIL"]),
            Words = UtilConvert.ToString(reader["WORDS"]),
            WordsLanguage = UtilConvert.ToString(reader["WORDS_LANGUAGE"]),
            Country = UtilConvert.ToString(reader["COUNTRY"]),
            StreetLine = UtilConvert.ToString(reader["STREET_LINE"]),
            City = UtilConvert.ToString(reader["CITY"]),
            Neighborhood = UtilConvert.ToString(reader["NEIGHBORHOOD"]),
            Region = UtilConvert.ToString(reader["REGION"]),
            Number = UtilConvert.ToString(reader["NUMBER"]),
            PostCode = UtilConvert.ToString(reader["POSTCODE"]),
            MobileNumber = UtilConvert.ToString(reader["MOBILE_NUMBER"]),
            PhoneNumber = UtilConvert.ToString(reader["PHONE_NUMBER"]),
            CPF = UtilConvert.ToString(reader["CPF"]),
            RG = UtilConvert.ToString(reader["RG"]),
            Gender = UtilConvert.ToChar(reader["GENDER"]),
            FirstName = UtilConvert.ToString(reader["FIRST_NAME"]),
            LastName = UtilConvert.ToString(reader["LAST_NAME"]),
            DateBirth = UtilConvert.ToDateTime(reader["DATE_BIRTH"]),
        };

        public List<Employee> ObterDescadastrados()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("EMPLOYEE");
            objSelect.Where.where("EMPLOYEE.ID", sqlElementWhereCommon.whereOperation.IS , null, sqlElementWhere.whereAssociation.OR)
                            .where("ACCESS.EMPLOYEE_ID", sqlElementWhereCommon.whereOperation.IS , null);
            objSelect.Join.fullJoin("ACCESS", "EMPLOYEE_ID", "EMPLOYEE.ID");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
                employee.Add(obter(reader));
            reader.Close();

            return employee;
        }

        public Employee ObterPorId()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Employee");
            objSelect.Where.where("ID", EmployeeId);    

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
                employee = obter(reader);
            reader.Close();

            return employee;
        }

        public Employee ObterInicialCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Employee");
            objSelect.Where.where("CPF", CPF + "%");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Employee employee = null;
            if (reader.Read())
                employee = obter(reader);
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
                .val("NEIGHBORHOOD", Neighborhood)
                .val("REGION", Region)
                .val("NUMBER", Number)
                .val("POSTCODE", PostCode)
                .val("MOBILE_NUMBER", MobileNumber)
                .val("PHONE_NUMBER", PhoneNumber);

            EmployeeId = objInsert.executeWithOutput(App.DatabaseSql);

            new Alert("O Funcionário foi devidamente cadastrado.", Type.Info);
        }

        public void AlterarPorId()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("Employee");
            objUpdate.Where.where("ID", EmployeeId);
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
                .val("NEIGHBORHOOD", Neighborhood)
                .val("REGION", Region)
                .val("NUMBER", Number)
                .val("POSTCODE", PostCode)
                .val("MOBILE_NUMBER", MobileNumber)
                .val("PHONE_NUMBER", PhoneNumber);

            objUpdate.execute(App.DatabaseSql);

            new Alert("O Funcionário foi devidamente alterado.", Type.Info);
        }
    }
}
