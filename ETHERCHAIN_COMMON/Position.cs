using caiosb.SqlMaster.Command;
using caiosb.Util.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    public class Position
    {
        private int _positionId;
        private string _name;

        public int PositionId { get => _positionId; set => _positionId = value; }
        public string Name { get => _name; set => _name = value; }

        private Position obter(SqlDataReader reader) => new Position
        {
            PositionId = UtilConvert.ToInt(reader["ID"]),
            Name = UtilConvert.ToString(reader["NAME"]),
        };

        public List<Position> ObterTodos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Position");

            List<Position> objAcessos = new List<Position>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objAcessos.Add(obter(reader));
            reader.Close();

            return objAcessos;
        }
    }
}
