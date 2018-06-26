// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CrossMVVM.iOS
{
    [Register ("TipDetailViewController")]
    partial class TipDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SubTotalLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TotalLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SubTotalLabel != null) {
                SubTotalLabel.Dispose ();
                SubTotalLabel = null;
            }

            if (TipLabel != null) {
                TipLabel.Dispose ();
                TipLabel = null;
            }

            if (TotalLabel != null) {
                TotalLabel.Dispose ();
                TotalLabel = null;
            }
        }
    }
}