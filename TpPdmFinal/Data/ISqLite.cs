using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TpPdmFinal.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
