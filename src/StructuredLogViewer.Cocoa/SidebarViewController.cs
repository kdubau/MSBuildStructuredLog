using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using ObjCRuntime;

namespace StructuredLogViewer.Cocoa
{
    public partial class SidebarViewController : AppKit.NSViewController
    {
        #region Constructors

        // Called when created from unmanaged code
        public SidebarViewController (NativeHandle handle) : base (handle)
        {
            Initialize ();
        }

        // Called when created directly from a XIB file
        [Export ("initWithCoder:")]
        public SidebarViewController (NSCoder coder) : base (coder)
        {
            Initialize ();
        }

        // Call to load from the XIB/NIB file
        public SidebarViewController () : base ("SidebarView", NSBundle.MainBundle)
        {
            Initialize ();
        }

        // Shared initialization code
        void Initialize ()
        { 
        }

        #endregion

        //strongly typed view accessor
        public new SidebarView View {
            get {
                return (SidebarView) base.View;
            }
        }

        public override void LoadView()
        {
            base.LoadView();


        }
    }
}
