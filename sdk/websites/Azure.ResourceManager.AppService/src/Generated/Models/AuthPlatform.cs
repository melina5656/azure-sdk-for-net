// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the platform of App Service Authentication/Authorization. </summary>
    public partial class AuthPlatform
    {
        /// <summary> Initializes a new instance of <see cref="AuthPlatform"/>. </summary>
        public AuthPlatform()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AuthPlatform"/>. </summary>
        /// <param name="isEnabled"> &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="runtimeVersion">
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </param>
        /// <param name="configFilePath">
        /// The path of the config file containing auth settings if they come from a file.
        /// If the path is relative, base will the site's root directory.
        /// </param>
        internal AuthPlatform(bool? isEnabled, string runtimeVersion, string configFilePath)
        {
            IsEnabled = isEnabled;
            RuntimeVersion = runtimeVersion;
            ConfigFilePath = configFilePath;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </summary>
        public string RuntimeVersion { get; set; }
        /// <summary>
        /// The path of the config file containing auth settings if they come from a file.
        /// If the path is relative, base will the site's root directory.
        /// </summary>
        public string ConfigFilePath { get; set; }
    }
}
