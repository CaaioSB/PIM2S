using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHERCHAIN_COMMON
{
    public class Access
    {
        private int _accessId;
        private string _cpf;
        private string _hash;
        private string _accessLevel;
        private bool _active;

        public int AccessId { get => _accessId; set => _accessId = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Hash { get => _hash; set => _hash = value; }
        public string AccessLevel { get => _accessLevel; set => _accessLevel = value; }
        public bool Active { get => _active; set => _active = value; }

        public int? AutenticarPorUsuario()
        {
            return 0;
        }

        public string AutenticarPorCPF()
        {
            return String.Empty;
        }

        public Access ObterPorCPF()
        {

            return new Access();
        }

        public Access ObterPorFuncionario()
        {

            return new Access();
        }

        public List<Access> ObterTodos()
        {
            return new List<Access>();
        }

        public bool Gravar()
        {
            return false;
        }

        public bool AlterarEstado()
        {
            return false;
        }
    }
}
