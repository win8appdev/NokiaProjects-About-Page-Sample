// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomePage.xaml.cs" company="Nokia Developer Wiki">
//   Copyright (c) 2013 Nokia Developer Wiki. All rights reserved.
// </copyright>
// <summary>
//   The home page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NokiaDev.AboutPageSample.Views
{
    using System;

    using Coding4Fun.Toolkit.Controls;

    using NokiaDev.AboutPageSample.Controls;

    /// <summary>
    /// The home page.
    /// </summary>
    public partial class HomePage 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button about click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnAboutClick(object sender, EventArgs e)
        {
            var aboutprompt = new AboutPrompt { Body = new AboutControl() };
            aboutprompt.Show();
        }
    }
}