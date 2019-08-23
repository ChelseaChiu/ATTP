using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATTP.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}

