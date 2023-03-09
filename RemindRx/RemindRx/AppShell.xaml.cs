using RemindRx.ViewModels;
using RemindRx.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RemindRx
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(AddMedicationPage), typeof(AddMedicationPage));
            Routing.RegisterRoute(nameof(AddAppointmentPage), typeof(AddAppointmentPage));
        }

    }
}
