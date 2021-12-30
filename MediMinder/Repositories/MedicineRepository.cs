using MediMinder.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediMinder.Repositories
{
    public class MedicineRepository
    {
        private readonly SQLiteConnection _connection;

        public MedicineRepository(SQLiteConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Medicine> List()
        {
            return _connection.Table<Medicine>().ToList();
        }
    }
}
