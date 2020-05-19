using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHERCHAIN_COMMON
{
    class CustomerJuridico : Customer
    {
        private string _CNPJ;
        private string _razaoSocial;

        public string CNPJ { get => _CNPJ; set => _CNPJ = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }

        public CustomerJuridico ObterPorCNPJ()
        {
            return new CustomerJuridico();
        }

        public List<CustomerJuridico> ObterTodos()
        {
            return new List<CustomerJuridico>();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
