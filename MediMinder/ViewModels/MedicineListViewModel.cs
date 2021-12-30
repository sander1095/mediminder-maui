using MediMinder.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediMinder.ViewModels
{
    public class MedicineListViewModel
    {
        public List<Medicine> MedicineList { get; set; } = new() { new() { Id = 1, Name = "Hello" }, new() { Id = 2, Name = "Melanie" } };        
    }
}
