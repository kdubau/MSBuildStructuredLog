using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using ObjCRuntime;

namespace StructuredLogViewer.Cocoa
{
    public partial class MainView : AppKit.NSSplitView
    {
        #region Constructors

        // Called when created from unmanaged code
        public MainView (NativeHandle handle) : base (handle)
        {
            Initialize ();
        }

        // Called when created directly from a XIB file
        [Export ("initWithCoder:")]
        public MainView (NSCoder coder) : base (coder)
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
