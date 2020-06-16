using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    class Founds
    {
        private int _foundsId;
        private byte _addressId;
        private int _cryptoCurrencyId;
        private int _cryptoCurrencyReceived;
        private int _cryptoCurrencySent;
        private int _cryptoCurrencyBalance;
        private int _cryptoCurrencyNTX;

        public int FoundsId { get => _foundsId; set => _foundsId = value; }
        public byte AddressId { get => _addressId; set => _addressId = value; }
        public int CryptoCurrencyId { get => _cryptoCurrencyId; set => _cryptoCurrencyId = value; }
        public int CryptoCurrencyReceived { get => _cryptoCurrencyReceived; set => _cryptoCurrencyReceived = value; }
        public int CryptoCurrencySent { get => _cryptoCurrencySent; set => _cryptoCurrencySent = value; }
        public int CryptoCurrencyBalance { get => _cryptoCurrencyBalance; set => _cryptoCurrencyBalance = value; }
        public int CryptoCurrencyNTX { get => _cryptoCurrencyNTX; set => _cryptoCurrencyNTX = value; }

        public Founds ObterPorId()
        {
            return new Founds();
        }

        public Founds ObterPorAddress()
        {
            return new Founds();
        }

        public Founds ObterTodos()
        {
            return new Founds();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
