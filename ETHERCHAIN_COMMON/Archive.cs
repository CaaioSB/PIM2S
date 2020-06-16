using caiosb.SqlMaster.Command;
using caiosb.Util.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uiCSB.Toastr;
using Type = uiCSB.Toastr.Type;

namespace Etherchain.Common
{
    public class Archive
    {
        private int _archiveId;
        private byte[] _blob;

        public int ArchiveId { get => _archiveId; set => _archiveId = value; }
        public byte[] Blob { get => _blob; set => _blob = value; }

        private Archive obter(SqlDataReader reader) => new Archive
        {
            ArchiveId = UtilConvert.ToInt(reader["ID"]),
            Blob = (byte[])reader["BLOB"]
        };


        public Archive ObterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("Archive");
            objSelect.Where.where("ID", ArchiveId);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Archive archive = null;
            if (reader.Read())
                archive = obter(reader);

            reader.Close();

            return archive;
        }

        public int Gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("Archive");
            objInsert.Value.val("BLOB", Blob);

            ArchiveId = objInsert.executeWithOutput(App.DatabaseSql);

            new Alert("A imagem foi salva no banco de dados com sucesso.", Type.Info);

            return ArchiveId;
        }
    }
}
