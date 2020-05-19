using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHERCHAIN_COMMON
{
    class CryptoCurency
    {
        private int _cryptoCurrencyId;
        private int _archiveId;
        private string _name;
        private string _base;
        private string _description;

        public int CryptoCurrencyId { get => _cryptoCurrencyId; set => _cryptoCurrencyId = value; }
        public int ArchiveId { get => _archiveId; set => _archiveId = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string Base { get => _base; set => _base = value; }

        public CryptoCurency ObterPorId()
        {
            return new CryptoCurency();
        }

        public CryptoCurency ObterPorName()
        {
            return new CryptoCurency();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
