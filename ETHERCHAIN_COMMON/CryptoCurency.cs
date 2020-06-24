using caiosb.SqlMaster.Command;
using caiosb.SqlMaster.Element.Where;
using caiosb.Util.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    public class Cryptocurency : CryptocurrencyFounds
    {
        private int _cryptocurrencyId;
        private int _archiveId;
        private string _name;
        private string _base;
        private string _description;

        public new int CryptocurrencyId { get => _cryptocurrencyId; set => _cryptocurrencyId = value; }
        public int ArchiveId { get => _archiveId; set => _archiveId = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string Base { get => _base; set => _base = value; }

        private Cryptocurency obter(SqlDataReader reader) => new Cryptocurency
        {
            CryptocurrencyId = UtilConvert.ToInt(reader["ID"]),
            ArchiveId = UtilConvert.ToInt(reader["ARCHIVE_ID"]),
            Name = UtilConvert.ToString(reader["NAME"]),
            Base = UtilConvert.ToString(reader["BASE"]),
            Description = UtilConvert.ToString(reader["DESCRIPTION"]),
            CryptocurrencyBalance = UtilConvert.ToInt(reader["CRYPTOCURRENCY_BALANCE"]),
            CryptocurrencyUnit = UtilConvert.ToString(reader["CRYPTOCURRENCY_UNIT"])
        };

        public Cryptocurency ObterPorId()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("CRYPTOCURRENCY");
            objSelect.Columns.selects(new string[] { "ID", "ARCHIVE_ID", "NAME", "BASE", "DESCRIPTION", "CRYPTOCURRENCY_FOUNDS.CRYPTOCURRENCY_BALANCE", "CRYPTOCURRENCY_FOUNDS.CRYPTOCURRENCY_UNIT" });
            objSelect.Join.innerJoin("CRYPTOCURRENCY_FOUNDS", "CRYPTOCURRENCY_ID", "CRYPTOCURRENCY.ID");
            objSelect.Where.where("CRYPTOCURRENCY.ID", CryptocurrencyId);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Cryptocurency cryptocurency = null;
            if (reader.Read())
            {
                cryptocurency = obter(reader);
            }
            reader.Close();

            return cryptocurency;
        }

        public Cryptocurency ObterPorName()
        {
            return new Cryptocurency();
        }

        public List<Cryptocurency> ObterTodos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("CRYPTOCURRENCY");
            objSelect.Columns.selects(new string[] { "ID", "ARCHIVE_ID", "NAME", "BASE", "DESCRIPTION", "CRYPTOCURRENCY_FOUNDS.CRYPTOCURRENCY_BALANCE", "CRYPTOCURRENCY_FOUNDS.CRYPTOCURRENCY_UNIT" });
            objSelect.Join.innerJoin("CRYPTOCURRENCY_FOUNDS", "CRYPTOCURRENCY_ID", "CRYPTOCURRENCY.ID");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<Cryptocurency> cryptocurencyList = new List<Cryptocurency>();
            while (reader.Read())
                cryptocurencyList.Add(obter(reader));

            reader.Close();
            return cryptocurencyList;
        }

        public new int Gravar()
        {
            sqlInsert insert = new sqlInsert();
            insert.table("CRYPTOCURRENCY");
            insert.Value.val("ARCHIVE_ID", ArchiveId)
                .val("NAME", Name)
                .val("BASE", Base)
                .val("DESCRIPTION", Description);

            int cryptocurrencyId = insert.executeWithOutput(App.DatabaseSql);
            int response = new CryptocurrencyFounds
            {
                CryptocurrencyId = cryptocurrencyId,
                CryptocurrencyBalance = CryptocurrencyBalance,
                CryptocurrencyUnit = CryptocurrencyUnit
            }.Gravar();

            return response;
        }

        public bool AlterarPorId()
        {
            sqlUpdate update = new sqlUpdate();
            update.table("CRYPTOCURRENCY");
            update.Value.val("ARCHIVE_ID", ArchiveId)
                .val("NAME", Name)
                .val("BASE", Base)
                .val("DESCRIPTION", Description);

            return UtilConvert.ToBool(update.execute(App.DatabaseSql));
        }
    }
}
