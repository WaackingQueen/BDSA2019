﻿using System.ComponentModel;
using Xamarin.Forms;

using BDSA2019.Lecture10.MobileApp.Models;
using BDSA2019.Lecture10.MobileApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace BDSA2019.Lecture10.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class EditSuperheroPage : ContentPage
    {
        private readonly SuperheroUpdateViewModel _viewModel;
        private readonly SuperheroDetailsDTO _superhero;

        public EditSuperheroPage(SuperheroDetailsDTO superhero)
        {
            InitializeComponent();

            _superhero = superhero;

            BindingContext = _viewModel = App.Container.GetRequiredService<SuperheroUpdateViewModel>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _viewModel.LoadCommand.Execute(_superhero);
        }
    }
}