﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RainbowMage.OverlayPlugin {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RainbowMage.OverlayPlugin.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to ACT tried to load {0} {1} which doesn&apos;t match your OverlayPlugin version ({2}). Aborting plugin load.
        ///
        ///Please make sure the old OverlayPlugin is disabled and restart ACT. If that doesn&apos;t fix the issue, remove the above mentioned file and any OverlayPlugin*.dll, CEF or HtmlRenderer.dll files in the same directory.
        ///.
        /// </summary>
        internal static string AssemblyMismatch {
            get {
                return ResourceManager.GetString("AssemblyMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AssemblyResolver: Error: {0}.
        /// </summary>
        internal static string AssemblyResolverError {
            get {
                return ResourceManager.GetString("AssemblyResolverError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AssemblyResolver: Loaded: {0}.
        /// </summary>
        internal static string AssemblyResolverLoaded {
            get {
                return ResourceManager.GetString("AssemblyResolverLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CefInstaller couldn&apos;t be loaded..
        /// </summary>
        internal static string CefInstallerFailed {
            get {
                return ResourceManager.GetString("CefInstallerFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Core or HtmlRenderer aren&apos;t sane..
        /// </summary>
        internal static string CoreOrHtmlRendererInsane {
            get {
                return ResourceManager.GetString("CoreOrHtmlRendererInsane", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load Common!.
        /// </summary>
        internal static string FailedToLoadCommon {
            get {
                return ResourceManager.GetString("FailedToLoadCommon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing CEF....
        /// </summary>
        internal static string InitCef {
            get {
                return ResourceManager.GetString("InitCef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing Runtime....
        /// </summary>
        internal static string InitRuntime {
            get {
                return ResourceManager.GetString("InitRuntime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for ACT to finish startup....
        /// </summary>
        internal static string WaitingForAct {
            get {
                return ResourceManager.GetString("WaitingForAct", resourceCulture);
            }
        }
    }
}
