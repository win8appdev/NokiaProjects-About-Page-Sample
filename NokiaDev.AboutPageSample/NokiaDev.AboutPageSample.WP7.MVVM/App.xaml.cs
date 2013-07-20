// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Nokia Developer Wiki">
//   Copyright (c) 2013 Nokia Developer Wiki. All rights reserved.
// </copyright>
// <summary>
//   Defines the App type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NokiaDev.AboutPageSample
{
    using System.Windows;
    using System.Windows.Navigation;

    using Microsoft.Phone.Controls;
    using Microsoft.Phone.Shell;

    /// <summary>
    /// The app.
    /// </summary>
    public partial class App
    {
        /// <summary>
        /// The phone application initialized. Avoid double-initialization
        /// </summary>
        private bool _phoneApplicationInitialized;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class. 
        /// Constructor for the Application object.
        /// </summary>
        public App()
        {
            // Global handler for uncaught exceptions. 
            this.UnhandledException += this.Application_UnhandledException;

            // Standard Silverlight initialization
            this.InitializeComponent();

            // Phone-specific initialization
            this.InitializePhoneApplication();

            // Show graphics profiling information while debugging.
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Display the current frame rate counters.
                Current.Host.Settings.EnableFrameRateCounter = true;

                // Show the areas of the app that are being redrawn in each frame.
                // Application.Current.Host.Settings.EnableRedrawRegions = true;

                // Enable non-production analysis visualization mode, 
                // which shows areas of a page that are handed off to GPU with a colored overlay.
                // Application.Current.Host.Settings.EnableCacheVisualization = true;

                // Disable the application idle detection by setting the UserIdleDetectionMode property of the
                // application's PhoneApplicationService object to Disabled.
                // Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
                // and consume battery power when the user is not using the phone.
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }
        }

        /// <summary>
        /// Gets the easy access to the root frame of the Phone Application.
        /// </summary>
        /// <returns>The root frame of the Phone Application.</returns>
        public PhoneApplicationFrame RootFrame { get; private set; }

        /// <summary>
        /// The application_ deactivated.
        /// Code to execute when the application is deactivated (sent to background)
        /// This code will not execute when the application is closing
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ApplicationDeactivated(object sender, DeactivatedEventArgs e)
        {
        }
        
        /// <summary>
        /// The application_ launching.
        /// Code to execute when the application is launching (example, from Start)
        /// This code will not execute when the application is reactivated
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ApplicationLaunching(object sender, LaunchingEventArgs e)
        {
        }

        /// <summary>
        /// Code to execute on Unhandled Exceptions
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        /// <summary>
        /// Code to execute when the application is activated (brought to foreground)
        /// This code will not execute when the application is first launched
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ApplicationActivated(object sender, ActivatedEventArgs e)
        {
        }

        /// <summary>
        /// Code to execute when the application is closing (example, user hit Back)
        /// This code will not execute when the application is deactivated
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ApplicationClosing(object sender, ClosingEventArgs e)
        {
        }

        /// <summary>
        /// The complete initialize phone application.
        ///  Do not add any additional code to this method
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Set the root visual to allow the application to render
            if (this.RootVisual != this.RootFrame)
            {
                this.RootVisual = this.RootFrame;
            }

            // Remove this handler since it is no longer needed
            this.RootFrame.Navigated -= this.CompleteInitializePhoneApplication;
        }

        /// <summary>
        /// Do not add any additional code to this method
        /// </summary>
        private void InitializePhoneApplication()
        {
            if (this._phoneApplicationInitialized)
            {
                return;
            }

            // Create the frame but don't set it as RootVisual yet; this allows the splash
            // screen to remain active until the application is ready to render.
            this.RootFrame = new PhoneApplicationFrame();
            this.RootFrame.Navigated += this.CompleteInitializePhoneApplication;

            // Handle navigation failures
            this.RootFrame.NavigationFailed += this.RootFrame_NavigationFailed;

            // Ensure we don't initialize again
            this._phoneApplicationInitialized = true;
        }

        /// <summary>
        /// Code to execute if a navigation fails
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // A navigation has failed; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}