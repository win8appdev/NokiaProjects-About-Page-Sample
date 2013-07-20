// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeViewModel.cs" company="Nokia Developer Wiki">
//   Copyright (c) 2013 Nokia Developer Wiki. All rights reserved.
// </copyright>
// <summary>
//   Defines the HomeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NokiaDev.AboutPageSample.ViewModels
{
    using System;
    using System.Windows.Input;

    using Cimbalino.Phone.Toolkit.Services;

    using GalaSoft.MvvmLight.Command;

    /// <summary>
    /// The home view model.
    /// </summary>
    public class HomeViewModel
    {
        /// <summary>
        /// The navigation service.
        /// </summary>
        private readonly INavigationService _navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">
        /// The navigation service.
        /// </param>
        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AboutCommand = new RelayCommand(this.ShowAbout);
        }

        /// <summary>
        /// Gets the about command.
        /// </summary>
        /// <value>
        /// The about command.
        /// </value>
        public ICommand AboutCommand { get; private set; }

        /// <summary>
        /// The show about.
        /// </summary>
        private void ShowAbout()
        {
            _navigationService.NavigateTo(new Uri("/Views/AboutPage.xaml", UriKind.Relative));
        }
    }
}
