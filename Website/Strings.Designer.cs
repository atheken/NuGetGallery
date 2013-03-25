﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGetGallery.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to The specified API key does not provide the authority to {0} packages..
        /// </summary>
        public static string ApiKeyNotAuthorized {
            get {
                return ResourceManager.GetString("ApiKeyNotAuthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be null or empty.
        /// </summary>
        public static string ArgumentCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current password you provided is incorrect..
        /// </summary>
        public static string CurrentPasswordIncorrect {
            get {
                return ResourceManager.GetString("CurrentPasswordIncorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email address &apos;{0}&apos; is being used..
        /// </summary>
        public static string EmailAddressBeingUsed {
            get {
                return ResourceManager.GetString("EmailAddressBeingUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read the package file..
        /// </summary>
        public static string FailedToReadUploadFile {
            get {
                return ResourceManager.GetString("FailedToReadUploadFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The API key &apos;{0}&apos; is invalid..
        /// </summary>
        public static string InvalidApiKey {
            get {
                return ResourceManager.GetString("InvalidApiKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A nuget package&apos;s {0} property may not be more than {1} characters long..
        /// </summary>
        public static string NuGetPackagePropertyTooLong {
            get {
                return ResourceManager.GetString("NuGetPackagePropertyTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A package with id &apos;{0}&apos; and version &apos;{1}&apos; already exists and cannot be modified..
        /// </summary>
        public static string PackageExistsAndCannotBeModified {
            get {
                return ResourceManager.GetString("PackageExistsAndCannotBeModified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package ID &apos;{0}&apos; is not available..
        /// </summary>
        public static string PackageIdNotAvailable {
            get {
                return ResourceManager.GetString("PackageIdNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package is already curated..
        /// </summary>
        public static string PackageIsAlreadyCurated {
            get {
                return ResourceManager.GetString("PackageIsAlreadyCurated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A package with id &apos;{0}&apos; and version &apos;{1}&apos; does not exist..
        /// </summary>
        public static string PackageWithIdAndVersionNotFound {
            get {
                return ResourceManager.GetString("PackageWithIdAndVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No package with this ID exists..
        /// </summary>
        public static string PackageWithIdDoesNotExist {
            get {
                return ResourceManager.GetString("PackageWithIdDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested resource can only be accessed via SSL..
        /// </summary>
        public static string SSLRequired {
            get {
                return ResourceManager.GetString("SSLRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You successfully uploaded {0} {1}..
        /// </summary>
        public static string SuccessfullyUploadedPackage {
            get {
                return ResourceManager.GetString("SuccessfullyUploadedPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not a migration type..
        /// </summary>
        public static string TypeIsNotAMigration {
            get {
                return ResourceManager.GetString("TypeIsNotAMigration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A package file is required..
        /// </summary>
        public static string UploadFileIsRequired {
            get {
                return ResourceManager.GetString("UploadFileIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file must be a .nupkg file..
        /// </summary>
        public static string UploadFileMustBeNuGetPackage {
            get {
                return ResourceManager.GetString("UploadFileMustBeNuGetPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot reset your password until you confirm your account..
        /// </summary>
        public static string UserIsNotYetConfirmed {
            get {
                return ResourceManager.GetString("UserIsNotYetConfirmed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The username &apos;{0}&apos; is not available..
        /// </summary>
        public static string UsernameNotAvailable {
            get {
                return ResourceManager.GetString("UsernameNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A user with the provided user name and password does not exist..
        /// </summary>
        public static string UserNotFound {
            get {
                return ResourceManager.GetString("UserNotFound", resourceCulture);
            }
        }
    }
}
