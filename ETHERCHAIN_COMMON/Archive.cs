using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHERCHAIN_COMMON
{
    class Archive
    {
        private int _archiveId;
        private byte _blob;

        public int ArchiveId { get => _archiveId; set => _archiveId = value; }
        public byte Blob { get => _blob; set => _blob = value; }

        public Archive ObterPorCod()
        {
            return new Archive();
        }

        public void Gravar()
        {

        }
    }
}
