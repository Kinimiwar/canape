//    CANAPE Network Testing Tool
//    Copyright (C) 2014 Context Information Security
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CANAPE.Net.Protocols.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CANAPE.Net.Protocols.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid content length value of &apos;{0}&apos; expecting number.
        /// </summary>
        internal static string HttpParser_InvalidContentLength {
            get {
                return ResourceManager.GetString("HttpParser_InvalidContentLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid HTTP header encountered during parse &apos;{0}&apos;.
        /// </summary>
        internal static string HttpParser_InvalidHeaderException {
            get {
                return ResourceManager.GetString("HttpParser_InvalidHeaderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP response code is invalid.
        /// </summary>
        internal static string HttpParser_InvalidHttpResponseCode {
            get {
                return ResourceManager.GetString("HttpParser_InvalidHttpResponseCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid HTTP version string encountered.
        /// </summary>
        internal static string HttpParser_InvalidHttpVersionString {
            get {
                return ResourceManager.GetString("HttpParser_InvalidHttpVersionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing method and path in frame.
        /// </summary>
        internal static string HttpParser_MissingMethodAndPath {
            get {
                return ResourceManager.GetString("HttpParser_MissingMethodAndPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing version and response code in frame.
        /// </summary>
        internal static string HttpParser_NoVersionResponseException {
            get {
                return ResourceManager.GetString("HttpParser_NoVersionResponseException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request header is invalid &apos;{0}&apos;.
        /// </summary>
        internal static string HttpParser_RequestHeaderInvalid {
            get {
                return ResourceManager.GetString("HttpParser_RequestHeaderInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response header is invalid &apos;{0}&apos;.
        /// </summary>
        internal static string HttpParser_ResponseHeaderInvalid {
            get {
                return ResourceManager.GetString("HttpParser_ResponseHeaderInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid line ending encountered during strict parsing.
        /// </summary>
        internal static string HttpParser_StrictParsingInvalidLineEnd {
            get {
                return ResourceManager.GetString("HttpParser_StrictParsingInvalidLineEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid version string.
        /// </summary>
        internal static string HttpVersion_InvalidVersionString {
            get {
                return ResourceManager.GetString("HttpVersion_InvalidVersionString", resourceCulture);
            }
        }
    }
}
