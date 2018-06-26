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
    [Register ("TipViewController")]
    partial class TipViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CommandButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider GenerousSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NewLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NextPageButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SubTotalTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITapGestureRecognizer TapGesture { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipLabel { get; set; }

        [Action ("TapGestureRecognized:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TapGestureRecognized (UIKit.UITapGestureRecognizer sender);

        void ReleaseDesignerOutlets ()
        {
            if (CommandButton != null) {
                CommandButton.Dispose ();
                CommandButton = null;
            }

            if (GenerousSlider != null) {
                GenerousSlider.Dispose ();
                GenerousSlider = null;
            }

            if (NewLabel != null) {
                NewLabel.Dispose ();
                NewLabel = null;
            }

            if (NextPageButton != null) {
                NextPageButton.Dispose ();
                NextPageButton = null;
            }

            if (SubTotalTextField != null) {
                SubTotalTextField.Dispose ();
                SubTotalTextField = null;
            }

            if (TapGesture != null) {
                TapGesture.Dispose ();
                TapGesture = null;
            }

            if (TipLabel != null) {
                TipLabel.Dispose ();
                TipLabel = null;
            }
        }
    }
}