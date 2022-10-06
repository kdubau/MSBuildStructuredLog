using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using ObjCRuntime;

namespace StructuredLogViewer.Cocoa
{
    public partial class SidebarView : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public SidebarView (NativeHandle handle) : base (handle)
        {
            Initialize ();
        }

        // Called when created directly from a XIB file
        [Export ("initWithCoder:")]
        public SidebarView (NSCoder coder) : base (coder)
        {
            Initialize ();
        }

        // Shared initialization code
        void Initialize ()
        {
            
        }

        #endregion
    }
}
