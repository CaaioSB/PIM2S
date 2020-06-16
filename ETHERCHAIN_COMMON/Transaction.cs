using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    class Transaction
    {
        private byte _hashId;
        private int _inputId;
        private int _outputId;
        private byte _addressId;
        private string _addresses;
        private int _amount;
        private DateTime received;
        private int vinSz;
        private int voutSz;

        public byte HashId { get => _hashId; set => _hashId = value; }
        public int InputId { get => _inputId; set => _inputId = value; }
        public int OutputId { get => _outputId; set => _outputId = value; }
        public byte AddressId { get => _addressId; set => _addressId = value; }
        public string Addresses { get => _addresses; set => _addresses = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public DateTime Received { get => received; set => received = value; }
        public int VinSz { get => vinSz; set => vinSz = value; }
        public int VoutSz { get => voutSz; set => voutSz = value; }

        public Transaction ObterPorHash()
        {
            return new Transaction();
        }

        public Transaction ObterPorAddress()
        {
            return new Transaction();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
