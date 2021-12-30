using SQLite;
using System;

namespace MediMinder.Models
{
    public class Medicine
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }        
        public string Name { get; set; }
        public TimeOnly TimeToSendReminder { get; set; }
        public int AmountOfPills { get; set; }
    }
}
