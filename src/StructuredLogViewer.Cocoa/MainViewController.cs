using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using ObjCRuntime;

namespace StructuredLogViewer.Cocoa
{
    public partial class MainViewController : AppKit.NSSplitViewController
    {
        #region Constructors

        // Called when created from unmanaged code
        public MainViewController (NativeHandle handle) : base (handle)
        {
            Initialize ();
        }

        // Called when created directly from a XIB file
        [Export ("initWithCoder:")]
        public MainViewController (NSCoder coder) : base (coder)
        {
            Initialize ();
        }

        // Call to load from the XIB/NIB file
        public MainViewController () : base ("MainView", NSBundle.MainBundle)
        {
            Initialize ();
        }

        // Shared initialization code
        void Initialize ()
        {
        }

        #endregion

        //strongly typed view accessor
        public new MainView View {
            get {
                return (MainView) base.View;
            }
        }
    }
}
