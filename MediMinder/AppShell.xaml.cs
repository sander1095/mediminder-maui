using MediMinder.Pages;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediMinder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public DateOnly YesterdayDate { get; } = DateOnly.FromDateTime(DateTime.Now).AddDays(-1);
        public DateOnly TodayDate { get; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly TomorrowDate { get; } = DateOnly.FromDateTime(DateTime.Now).AddDays(1);


        public AppShell()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
