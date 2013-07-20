namespace NokiaDev.RadControlsSample
{
    using System.Windows;

    using Cimbalino.Phone.Toolkit.Helpers;
    using Cimbalino.Phone.Toolkit.Services;

    /// <summary>
    /// The about.
    /// </summary>
    public partial class About 
    {
        /// <summary>
        /// The application mnifest
        /// </summary>
        private ApplicationManifest _applicationMnifest;

        /// <summary>
        /// Initializes a new instance of the <see cref="About"/> class.
        /// </summary>
        public About()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The about_ loaded.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AboutLoaded(object sender, RoutedEventArgs e)
        {
            var applicationManifestService = new ApplicationManifestService();
            _applicationMnifest = applicationManifestService.GetApplicationManifest();

        }

        /// <summary>
        /// Gets the name of the aplication.
        /// </summary>
        /// <value>
        /// The name of the aplication.
        /// </value>
        public string AplicationName
        {
            get
            {
                return _applicationMnifest.App.Title;

            }
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public string Version
        {
            get
            {
                return _applicationMnifest.App.Version;

            }
        }
    }
}
