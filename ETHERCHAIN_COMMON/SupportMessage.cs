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
    public enum Method
    {
        SENTED,
        RECEIVED
    }

    public class SupportMessage
    {
        private int _supportId;
        private int _customerId;
        private int _employeeId;
        private string _message;
        private DateTime _sentedAt;
        private bool _finished;
        private Method _method;

        public int SupportId { get => _supportId; set => _supportId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime SentedAt { get => _sentedAt; set => _sentedAt = value; }
        public bool Finished { get => _finished; set => _finished = value; }
        public Method Method { get => _method; set => _method = value; }

        private SupportMessage obter(SqlDataReader reader) => new SupportMessage
        {
            SupportId = UtilConvert.ToInt(reader["SUPPORT_ID"]),
            CustomerId = UtilConvert.ToInt(reader["CUSTOMER_ID"]),
            EmployeeId = UtilConvert.ToInt(reader["EMPLOYEE_ID"]),
            Message = UtilConvert.ToString(reader["MESSAGE"]),
            SentedAt = UtilConvert.ToDate(reader["SENTED_AT"]),
            Method = (Method)Enum.Parse(typeof(Method), UtilConvert.ToString(reader["METHOD"]))
        };

        public List<SupportMessage> ObterPorId()
        {
            sqlSelect select = new sqlSelect();
            select.table("SUPPORT_MESSAGES");
            select.Where.where("SUPPORT_ID", SupportId);
            select.Order.order("SENTED_AT", caiosb.SqlMaster.Element.sqlElementOrder.orderOperation.ASC);

            SqlDataReader reader = select.execute(App.DatabaseSql);
            List<SupportMessage> supportMessages = new List<SupportMessage>();

            while (reader.Read())
                supportMessages.Add(obter(reader));

            reader.Close();
            return supportMessages;
        }

        public void Gravar()
        {
            sqlInsert insert = new sqlInsert();
            insert.table("SUPPORT_MESSAGES");
            insert.Value.val("SUPPORT_ID", SupportId)
                .val("CUSTOMER_ID", CustomerId)
                .val("EMPLOYEE_ID", EmployeeId)
                .val("MESSAGE", Message)
                .val("SENTED_AT", DateTime.Now)
                .val("METHOD", Method.ToString());
            insert.execute(App.DatabaseSql);
            //await Task.Run(() => insert.execute(App.DatabaseSql));
        }
    }
}
