﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Web.LibraryInstaller.Vsix.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Text {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Text() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Web.LibraryInstaller.Vsix.Resources.Text", typeof(Text).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check for updates.
        /// </summary>
        public static string CheckForUpdates {
            get {
                return ResourceManager.GetString("CheckForUpdates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clean libraries started....
        /// </summary>
        public static string CleanLibrariesStarted {
            get {
                return ResourceManager.GetString("CleanLibrariesStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clean libraries succeeded.
        /// </summary>
        public static string CleanLibrariesSucceeded {
            get {
                return ResourceManager.GetString("CleanLibrariesSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore completed. Files already up-to-date.
        /// </summary>
        public static string LibraryRestoredNoChange {
            get {
                return ResourceManager.GetString("LibraryRestoredNoChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading....
        /// </summary>
        public static string Loading {
            get {
                return ResourceManager.GetString("Loading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No updates found at this time.
        /// </summary>
        public static string NoUpdatesFound {
            get {
                return ResourceManager.GetString("NoUpdatesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A NuGet package will be installed to augment the MSBuild process, but no files will be added to the project.
        ///
        ///This may require an internet connection.
        ///
        ///Do you want to continue?.
        /// </summary>
        public static string NugetInstallPrompt {
            get {
                return ResourceManager.GetString("NugetInstallPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packages could not be loaded.
        /// </summary>
        public static string PackagesCouldNotBeLoaded {
            get {
                return ResourceManager.GetString("PackagesCouldNotBeLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Choose a package to select files to install&gt;.
        /// </summary>
        public static string SelectPackageToSelectFilesToInstall {
            get {
                return ResourceManager.GetString("SelectPackageToSelectFilesToInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Type to search&gt;.
        /// </summary>
        public static string TypeToSearch {
            get {
                return ResourceManager.GetString("TypeToSearch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall {0}.
        /// </summary>
        public static string UninstallLibrary {
            get {
                return ResourceManager.GetString("UninstallLibrary", resourceCulture);
            }
        }
    }
}
