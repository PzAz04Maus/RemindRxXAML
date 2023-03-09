using RemindRx.Models;
using RemindRx.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemindRx.Views
{
    public partial class AddAppointmentPage : ContentPage
    {
        public Item Item { get; set; }

        public AddAppointmentPage()
        {
            InitializeComponent();
            BindingContext = new AddAppointmentViewModel();
        }
    }
}