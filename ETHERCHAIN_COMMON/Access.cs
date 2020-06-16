using caiosb.SqlMaster.Command;
using caiosb.Util.Data;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using uiCSB.Toastr;

namespace Etherchain.Common
{
    public class Access
    {
        private int _accessId;
        private int _employeeId;
        private int _positionId;
        private string _cpf;
        private string _hash;
        private bool _active;

        public int AccessId { get => _accessId; set => _accessId = value; }
        public int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public int PositionId { get => _positionId; set => _positionId = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Hash { get => _hash; set => _hash = value; }
        public bool Active { get => _active; set => _active = value; }

        private Access obter(SqlDataReader reader) => new Access
        {
            AccessId = UtilConvert.ToInt(reader["ID"]),
            EmployeeId = UtilConvert.ToInt(reader["EMPLOYEE_ID"]),
            PositionId = UtilConvert.ToInt(reader["POSITION_ID"]),
            Cpf = UtilConvert.ToString(reader["CPF"]),
            Hash = UtilConvert.ToString(reader["HASH"]),
            Active = UtilConvert.ToBool(reader["ACTIVE"])
        };

        public int? AutenticarPorCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Access");
            objSelect.Columns.select("EMPLOYEE_ID");
            objSelect.Where.where("CPF", caiosb.SqlMaster.Element.Where.sqlElementWhereCommon.whereOperation.EQUALS, Cpf)
                           .where("HASH", caiosb.SqlMaster.Element.Where.sqlElementWhereCommon.whereOperation.EQUALS, Hash)
                           .where("ACTIVE", UtilConvert.ToBit(Active));

            int? codFuncionario = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                codFuncionario = UtilConvert.ToInt(reader["EMPLOYEE_ID"]);
            reader.Close();

            return codFuncionario;
        }

        public Access ObterPorId()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Access");
            objSelect.Columns.select("ID");
            objSelect.Columns.select("EMPLOYEE_ID");
            objSelect.Columns.select("POSITION_ID");
            objSelect.Columns.select("CPF");
            objSelect.Columns.select("HASH");
            objSelect.Columns.select("ACTIVE");
            objSelect.Where.where("EMPLOYEE_ID", EmployeeId);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Access access = null;
            while (reader.Read())
                access = obter(reader);
            reader.Close();

            return access;

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
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Access");

            List<Access> objAcessos = new List<Access>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objAcessos.Add(obter(reader));
            reader.Close();

            return objAcessos;
        }

        public void Gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("ACCESS");
            objInsert.Value.val("POSITION_ID", PositionId)
                .val("EMPLOYEE_ID", EmployeeId)
                .val("CPF", Cpf)
                .val("HASH", Hash)
                .val("ACTIVE", Active);

            EmployeeId = objInsert.executeWithOutput(App.DatabaseSql);

            new Alert("O acesso foi devidamente cadastrado.", uiCSB.Toastr.Type.Info);
        }

        public bool AlterarEstado()
        {
            return false;
        }
    }
}
