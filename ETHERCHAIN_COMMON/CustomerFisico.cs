using caiosb.SqlMaster.Command;
using caiosb.Util.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    public class CustomerFisico : Customer
    {
        private string _CPF;
        private string _RG;
        private char _gender;
        private string _firstName;
        private string _lastName;
        private DateTime _dateBirth;

        public string CPF { get => _CPF; set => _CPF = value; }
        public string RG { get => _RG; set => _RG = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateBirth { get => _dateBirth; set => _dateBirth = value; }

        private CustomerFisico obter(SqlDataReader reader) => new CustomerFisico
        {
            CustomerId = UtilConvert.ToInt(reader["ID"]),
            FirstName = UtilConvert.ToString(reader["FIRST_NAME"]),
            LastName = UtilConvert.ToString(reader["LAST_NAME"]),
            Gender = UtilConvert.ToChar(reader["GENDER"]),
            DateBirth = UtilConvert.ToDate(reader["DATE_BIRTH"]),
            RG = UtilConvert.ToString(reader["RG"]),
            CPF = UtilConvert.ToString(reader["CPF"]),
            Email = UtilConvert.ToString(reader["EMAIL"]),
            Words = UtilConvert.ToString(reader["WORDS"]),
            WordsLanguage = UtilConvert.ToString(reader["WORDS_LANGUAGE"]),
            Country = UtilConvert.ToString(reader["COUNTRY"]),
            StreetLine = UtilConvert.ToString(reader["STREET_LINE"]),
            City = UtilConvert.ToString(reader["CITY"]),
            Region = UtilConvert.ToString(reader["REGION"]),
            PostCode = UtilConvert.ToString(reader["POSTCODE"]),
            MobileNumber = UtilConvert.ToString(reader["MOBILE_NUMBER"])
        };

        public CustomerFisico ObterPorId()
        {
            sqlSelect select = new sqlSelect();
            select.table("CUSTOMER");
            select.Join.innerJoin("CUSTOMER_FISICO", "CUSTOMER_ID", "CUSTOMER.ID");
            select.Where.where("ID", CustomerId);

            CustomerFisico customer = null;
            SqlDataReader reader = select.execute(App.DatabaseSql);
            if (reader.Read())
                customer = obter(reader);
            reader.Close();

            return customer;
        }

        public List<CustomerFisico> ObterTodos()
        {
            sqlSelect select = new sqlSelect();
            select.table("CUSTOMER");
            select.Join.innerJoin("CUSTOMER_FISICO", "CUSTOMER_ID", "CUSTOMER.ID");

            List<CustomerFisico> customers = new List<CustomerFisico>();
            SqlDataReader reader = select.execute(App.DatabaseSql);
            while (reader.Read())
                customers.Add(obter(reader));
            reader.Close();

            return customers;
        }

        public CustomerFisico ObterPorCPF()
        {
            sqlSelect select = new sqlSelect();
            select.table("CUSTOMER");
            select.Join.innerJoin("CUSTOMER_FISICO", "CUSTOMER_ID", "CUSTOMER.ID");
            select.Where.where("CPF", CPF);

            CustomerFisico customer = null;
            SqlDataReader reader = select.execute(App.DatabaseSql);
            if (reader.Read())
                customer = obter(reader);
            reader.Close();

            return customer;
        }

        public CustomerFisico ObterPorRG()
        {
            sqlSelect select = new sqlSelect();
            select.table("CUSTOMER");
            select.Join.innerJoin("CUSTOMER_FISICO", "CUSTOMER_ID", "CUSTOMER.ID");
            select.Where.where("RG", RG);

            CustomerFisico customer = null;
            SqlDataReader reader = select.execute(App.DatabaseSql);
            if (reader.Read())
                customer = obter(reader);
            reader.Close();

            return customer;
        }

        public bool Gravar() { return false; }
     
        public bool AlterarPorId() { return false; }
    }
}
