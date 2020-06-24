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
    public class Support
    {
        private int _supportId;
        private int _customerId;
        private int _employeeId;
        private string _title;
        private string _description;
        private DateTime _createdAt;
        private bool _finished;

        public int SupportId { get => _supportId; set => _supportId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime CreatedAt { get => _createdAt.Date; set => _createdAt = value; }
        public bool Finished { get => _finished; set => _finished = value; }

        private Support obter(SqlDataReader reader) => new Support
        {
            SupportId = UtilConvert.ToInt(reader["ID"]),
            CustomerId = UtilConvert.ToInt(reader["CUSTOMER_ID"]),
            EmployeeId = UtilConvert.ToInt(reader["EMPLOYEE_ID"]),
            Title = UtilConvert.ToString(reader["TITLE"]),
            Description = UtilConvert.ToString(reader["DESCRIPTION"]),
            CreatedAt = UtilConvert.ToDate(reader["CREATED_AT"]),
            Finished = UtilConvert.ToBool(reader["FINISHED"])
        };

        public Support ObterPorId()
        {
            sqlSelect sqlSelect = new sqlSelect();
            sqlSelect.table("SUPPORT");
            sqlSelect.Where.where("ID", SupportId);

            SqlDataReader reader = sqlSelect.execute(App.DatabaseSql);
            Support support = null;

            if (reader.Read())
                support = obter(reader);
            reader.Close();

            return support;
        }

        public List<Support> ObterTodos()
        {
            sqlSelect sqlSelect = new sqlSelect();
            sqlSelect.table("SUPPORT");

            SqlDataReader reader = sqlSelect.execute(App.DatabaseSql);
            List<Support> support = new List<Support>();

            while (reader.Read())
                support.Add(obter(reader));
            reader.Close();

            return support;
        }
    }
}
