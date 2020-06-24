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
    public class Wallet : Founds
    {
        private int _walletId;
        private int _customerId;
        private int _qrCodeId;
        private string _address;
        private string _seed;
        private byte[] _privateKey;
        private byte[] _chainCode;
        private byte[] _publicKey;
        private byte[] _hash160;

        public new int WalletId { get => _walletId; set => _walletId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public int QrCodeId { get => _qrCodeId; set => _qrCodeId = value; }
        public string Address { get => _address; set => _address = value; }
        public string Seed { get => _seed; set => _seed = value; }
        public byte[] PrivateKey { get => _privateKey; set => _privateKey = value; }
        public byte[] ChainCode { get => _chainCode; set => _chainCode = value; }
        public byte[] PublicKey { get => _publicKey; set => _publicKey = value; }
        public byte[] Hash160 { get => _hash160; set => _hash160 = value; }

        private Wallet obter(SqlDataReader reader) => new Wallet
        {
            // WALLET
            WalletId = UtilConvert.ToInt(reader["WALLET_ID"]),
            CustomerId = UtilConvert.ToInt(reader["CUSTOMER_ID"]),
            QrCodeId = UtilConvert.ToInt(reader["QRCODE_ID"]),
            Seed = UtilConvert.ToString(reader["SEED"]),
            PrivateKey = UtilConvert.ToByte(reader["PRIVATE_KEY"]),
            ChainCode = UtilConvert.ToByte(reader["CHAIN_CODE"]),
            PublicKey = UtilConvert.ToByte(reader["PUBLIC_KEY"]),
            Hash160 = UtilConvert.ToByte(reader["HASH160"]),


            // FOUNDS
            CryptoCurrencyId = UtilConvert.ToInt(reader["CRYPTOCURRENCY_ID"]),
            CryptoCurrencyReceived = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_RECEIVED"]),
            CryptoCurrencySent = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_SENT"]),
            CryptoCurrencyBalance = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_BALANCE"]),
            CryptoCurrencyNTX = UtilConvert.ToInt(reader["CRYPTOCURRENCY_NTX"])
        };

        private Wallet obterPorHeranca(SqlDataReader reader) => new Wallet
        {
            // WALLET
            WalletId = UtilConvert.ToInt(reader["WALLET_ID"]),
            CustomerId = UtilConvert.ToInt(reader["CUSTOMER_ID"]),
            Address = UtilConvert.ToString(reader["ADDRESS"]),

            // FOUNDS
            CryptoCurrencyId = UtilConvert.ToInt(reader["CRYPTOCURRENCY_ID"]),
            CryptoCurrencyReceived = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_RECEIVED"]),
            CryptoCurrencySent = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_SENT"]),
            CryptoCurrencyBalance = UtilConvert.ToDecimal(reader["CRYPTOCURRENCY_BALANCE"]),
            CryptoCurrencyNTX = UtilConvert.ToInt(reader["CRYPTOCURRENCY_NTX"])
        };

        /// <summary>
        /// Este método retornará além dos dados da "Wallet", os fundos baseados na identificação (id) do cliente e da criptomoeda.
        /// </summary>
        /// <returns>Objeto com informações da determinada carteira.</returns>
        public Wallet ObterPorId()
        {
            sqlSelect select = new sqlSelect();
            select.table("WALLET");
            select.Columns.select("CUSTOMER_ID");
            select.Columns.select("WALLET_ID");
            select.Columns.select("ADDRESS");
            select.Columns.select("CRYPTOCURRENCY_ID");
            select.Columns.select("CRYPTOCURRENCY_RECEIVED");
            select.Columns.select("CRYPTOCURRENCY_SENT");
            select.Columns.select("CRYPTOCURRENCY_BALANCE");
            select.Columns.select("CRYPTOCURRENCY_NTX");
            select.Join.innerJoin("FOUNDS", "WALLET_ID", "WALLET.ID");
            select.Join.innerJoin("CRYPTOCURRENCY", "ID", "FOUNDS.WALLET_ID");
            select.Where.where("CUSTOMER_ID", CustomerId);
            select.Where.where("CRYPTOCURRENCY_ID", CryptoCurrencyId);

            Wallet wallet = null;
            SqlDataReader reader = select.execute(App.DatabaseSql);

            if (reader.Read())
                wallet = obterPorHeranca(reader);
            reader.Close();

            return wallet;
        }
        public Wallet ObterPorWallet() { return new Wallet(); }
        public Wallet ObterPorAddress() { return new Wallet(); }
        public Wallet ObterPorQrCode() { return new Wallet(); }
        public Wallet ObterPorPublicKey() { return new Wallet(); }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
