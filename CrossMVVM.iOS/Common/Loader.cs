using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Airbnb.Lottie;
using CoreGraphics;
using CrossMVVM.iOS;
using Foundation;
using UIKit;

namespace Common.iOS
{
    public class Loader
    {
        private bool _show = false;
        private bool _excuteOnce = true;
        private string _callerName = String.Empty;
        private UIView _backgroundView = new UIView(UIScreen.MainScreen.Bounds);
        private UIView _fromView = UIApplication.SharedApplication.KeyWindow;
        private UIStackView _containerView = new UIStackView();
        private LOTAnimationView _animation = LOTAnimationView.AnimationNamed("Loading");

        public bool Show
        {
            get => _show;
            set
            {
                _show = value;
                if (value)
                {
                    _animation.Play();
                    UpdateView();
                    _fromView.AddSubview(_backgroundView);
                }
                else
                {
                    _animation.Stop();
                    _backgroundView.RemoveFromSuperview();
                }
            }
        }

        private void UpdateView()
        {
            if (_excuteOnce)
            {
                //Update Animation View Frame
                _backgroundView.Frame = _fromView.Frame;
                var x = _backgroundView.Frame.GetMidX() - _containerView.Frame.GetMidX();
                var y = _backgroundView.Frame.GetMidY() - _containerView.Frame.GetMidY();
                _containerView.Frame = new CGRect(x, y, _containerView.Frame.Width, _containerView.Frame.Height);
            }
        }

        public Loader(UIView fromView = null)
        {
            _fromView = fromView ?? _fromView;
            _backgroundView.BackgroundColor = UIColor.Black;
            _backgroundView.Alpha = nfloat.Parse("0.75");

            _animation.LoopAnimation = true;
            //_animation.Frame = new CGRect(0f, 0f, 100f, 100f);
            _containerView.Frame = new CGRect(0f, 0f, 100f, 100f);
            _containerView.AddArrangedSubview(_animation);
            _containerView.LayoutIfNeeded();
            _backgroundView.AddSubview(_containerView);
        }
    }
}