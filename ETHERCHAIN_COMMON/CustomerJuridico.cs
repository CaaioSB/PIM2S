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
    public class CustomerJuridico : Customer
    {
        private string _CNPJ;
        private string _razaoSocial;

        public string CNPJ { get => _CNPJ; set => _CNPJ = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }

        private CustomerJuridico obter(SqlDataReader reader) => new CustomerJuridico
        {
            CustomerId = UtilConvert.ToInt(reader["ID"]),
            Email = UtilConvert.ToString(reader["EMAIL"]),
            CNPJ = UtilConvert.ToString(reader["CNPJ"]),
            RazaoSocial  =UtilConvert.ToString(reader["RAZAO_SOCIAL"]),
            Words = UtilConvert.ToString(reader["WORDS"]),
            WordsLanguage = UtilConvert.ToString(reader["WORDS_LANGUAGE"]),
            Country = UtilConvert.ToString(reader["COUNTRY"]),
            StreetLine = UtilConvert.ToString(reader["STREET_LINE"]),
            City = UtilConvert.ToString(reader["CITY"]),
            Region = UtilConvert.ToString(reader["REGION"]),
            PostCode = UtilConvert.ToString(reader["POSTCODE"]),
            //MobileNumber = UtilConvert.ToString(reader["MOBILE_NUMBER"])
        };

        public CustomerJuridico ObterPorCNPJ()
        {
            sqlSelect select = new sqlSelect();
            select.table("CUSTOMER");
            select.Join.innerJoin("CUSTOMER_JURIDICO", "CUSTOMER_ID", "CUSTOMER.ID");
            select.Where.where("CNPJ", CNPJ);

            CustomerJuridico customer = null;
            SqlDataReader reader = select.execute(App.DatabaseSql);
            if (reader.Read())
                customer = obter(reader);
            reader.Close();

            return customer;
        }

        public List<CustomerJuridico> ObterTodos()
        {
            sqlSelect select = new sqlSelect();
            select.table("CUSTOMER");
            select.Join.innerJoin("CUSTOMER_JURIDICO", "CUSTOMER_ID", "CUSTOMER.ID");

            List<CustomerJuridico> customers = new List<CustomerJuridico>();
            SqlDataReader reader = select.execute(App.DatabaseSql);
            while (reader.Read())
                customers.Add(obter(reader));
            reader.Close();

            return customers;
        }

        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
