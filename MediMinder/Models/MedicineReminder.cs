using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediMinder.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeOnly TimeToSendReminder { get; set; }
        public int AmountOfPills { get; set; }
    }
}
