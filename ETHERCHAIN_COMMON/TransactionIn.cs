using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    class TransactionIn
    {
        private int _inputId;
        private byte _hashId;
        private byte _address;

        public int InputId { get => _inputId; set => _inputId = value; }
        public byte HashId { get => _hashId; set => _hashId = value; }
        public byte Address { get => _address; set => _address = value; }

        public TransactionIn ObterPorAddress()
        {
            return new TransactionIn();
        }

        public TransactionIn ObterPorHash()
        {
            return new TransactionIn();
        }

        public TransactionIn ObterPorId()
        {
            return new TransactionIn();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
