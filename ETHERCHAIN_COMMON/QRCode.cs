using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    class QRCode
    {
        private int _QRCodeId;
        private byte _blob;

        public int QRCodeId { get => _QRCodeId; set => _QRCodeId = value; }
        public byte Blob { get => _blob; set => _blob = value; }

        public QRCode ObterPorId()
        {
            return new QRCode();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
