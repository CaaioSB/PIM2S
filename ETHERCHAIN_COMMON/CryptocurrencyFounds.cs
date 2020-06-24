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
    public class CryptocurrencyFounds
    {
        private int _cryptocurrencyId;
        private int _cryptocurrencyBalance;
        private string _cryptocurrencyUnit;

        public int CryptocurrencyId { get => _cryptocurrencyId; set => _cryptocurrencyId = value; }
        public int CryptocurrencyBalance { get => _cryptocurrencyBalance; set => _cryptocurrencyBalance = value; }
        public string CryptocurrencyUnit { get => _cryptocurrencyUnit; set => _cryptocurrencyUnit = value; }

        private CryptocurrencyFounds obter(SqlDataReader reader) => new CryptocurrencyFounds
        {
            CryptocurrencyId = UtilConvert.ToInt(reader["CRYPTOCURRENCY_ID"]),
            CryptocurrencyBalance = UtilConvert.ToInt(reader["CRYPTOCURRENCY_BALANCE"]),
            CryptocurrencyUnit = UtilConvert.ToString(reader["CRYPTOCURRENCY_UNIT"])
        };

        public int Gravar()
        {
            sqlInsert insert = new sqlInsert();
            insert.table("CRYPTOCURRENCY_FOUNDS");
            insert.Value.val("CRYPTOCURRENCY_ID", CryptocurrencyId)
                .val("CRYPTOCURRENCY_BALANCE", CryptocurrencyBalance)
                .val("CRYPTOCURRENCY_UNIT", CryptocurrencyUnit);

            return insert.execute(App.DatabaseSql);
        }
    }
}
