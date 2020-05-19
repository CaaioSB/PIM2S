using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHERCHAIN_COMMON
{
    class TransactionOut
    {
        private int outputId;
        private byte hashId;
        private byte address;
        private int amount;

        public int OutputId { get => outputId; set => outputId = value; }
        public byte HashId { get => hashId; set => hashId = value; }
        public byte Address { get => address; set => address = value; }
        public int Amount { get => amount; set => amount = value; }

        public TransactionOut ObterPorAddress()
        {
            return new TransactionOut();
        }

        public TransactionOut ObterPorHash()
        {
            return new TransactionOut();
        }

        public TransactionOut ObterPorId()
        {
            return new TransactionOut();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
