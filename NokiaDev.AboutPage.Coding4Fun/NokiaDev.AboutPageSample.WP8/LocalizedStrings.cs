// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocalizedStrings.cs" company="Nokia Developer Wiki">
//   Copyright (c) 2013 Nokia Developer Wiki. All rights reserved.
// </copyright>
// <summary>
//   Provides access to string resources.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NokiaDev.AboutPageSample.WP8
{
    using NokiaDev.AboutPageSample.WP8.Resources;

    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        /// <summary>
        /// The _localized resources.
        /// </summary>
        private static readonly AppResources _localizedResources = new AppResources();

        /// <summary>
        /// Gets the localized resources.
        /// </summary>
        public AppResources LocalizedResources
        {
            get
            {
                return _localizedResources;
            }
        }
    }
}