using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TpPdmFinal.Data
{
    interface ISqLite
    {
        SQLiteConnection GetConexao();
    }
}
