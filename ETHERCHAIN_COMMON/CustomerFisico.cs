using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHERCHAIN_COMMON
{
    class CustomerFisico : Customer
    {
        private string _CPF;
        private string _RG;
        private char _gender;
        private string _firstName;
        private string _lastName;
        private DateTime _dataNascimento;

        public string CPF { get => _CPF; set => _CPF = value; }
        public string RG { get => _RG; set => _RG = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }

        public CustomerFisico ObterPorCPF()
        {
            return new CustomerFisico();
        }

        public CustomerFisico ObterPorRG()
        {
            return new CustomerFisico();
        }

        public List<CustomerFisico> ObterTodos()
        {
            return new List<CustomerFisico>();
        }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
