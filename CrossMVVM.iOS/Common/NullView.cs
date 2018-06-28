using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;

namespace CrossMVVM.iOS.Common
{
    public class NullView
    {
        private bool _show = false;
        private bool _excuteOnce = true;
        private UIView _backgroundView = new UIView(UIScreen.MainScreen.Bounds);
        private UIView _fromView = UIApplication.SharedApplication.KeyWindow;
        private UIView _nullView = new UIStackView();

        public bool Show
        {
            get => _show;
            set
            {
                _show = value;
                if (value)
                {
                    _fromView.AddSubview(_backgroundView);
                    UpdateView();
                }
                else
                {
                    _backgroundView.RemoveFromSuperview();
                }
            }
        }

        public NullView(UIView fromView = null)
        {
            _fromView = fromView ?? _fromView;
            _backgroundView.BackgroundColor = UIColor.White;
            _backgroundView.AddSubview(_nullView);
        }

        private void UpdateView()
        {
            if (_excuteOnce)
            {
                //Update Frame
                var x = _backgroundView.Frame.GetMidX() - nfloat.Parse("50");
                var y = _backgroundView.Frame.GetMidY() - nfloat.Parse("50");
                _nullView.Frame = new CGRect(x, y, 100, 100);
                
            }
        }
    }
}