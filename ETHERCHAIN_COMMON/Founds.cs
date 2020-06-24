using caiosb.Util.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Etherchain.Common
{
    public class Founds
    {
        private int _walletId;
        private int _cryptoCurrencyId;
        private decimal _cryptoCurrencyReceived;
        private decimal _cryptoCurrencySent;
        private decimal _cryptoCurrencyBalance;
        private int _cryptoCurrencyNTX;

        public int WalletId { get => _walletId; set => _walletId = value; }
        public int CryptoCurrencyId { get => _cryptoCurrencyId; set => _cryptoCurrencyId = value; }
        public decimal CryptoCurrencyReceived { get => _cryptoCurrencyReceived; set => _cryptoCurrencyReceived = value; }
        public decimal CryptoCurrencySent { get => _cryptoCurrencySent; set => _cryptoCurrencySent = value; }
        public decimal CryptoCurrencyBalance { get => _cryptoCurrencyBalance; set => _cryptoCurrencyBalance = value; }
        public int CryptoCurrencyNTX { get => _cryptoCurrencyNTX; set => _cryptoCurrencyNTX = value; }

        private Founds obter(SqlDataReader reader) => new Founds
        {
            WalletId = UtilConvert.ToInt(reader["WALLET_ID"]),
            CryptoCurrencyId = UtilConvert.ToInt(reader["CRYPTOCURRENCY_ID"]),
            CryptoCurrencyReceived = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_RECEIVED"]),
            CryptoCurrencySent = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_SENT"]),
            CryptoCurrencyBalance = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_BALANCE"]),
            CryptoCurrencyNTX = UtilConvert.ToInt(reader["CRYPTOCURRENCY_NTX"])
        };
    }
}
