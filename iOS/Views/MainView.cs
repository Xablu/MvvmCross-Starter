﻿using System;
using BasicApp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace BasicApp.iOS.Views
{
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView() : base("MainView", null)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            lblHello.Text = "test";
            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(lblHello).To(vm => vm.Title);
            set.Apply();
        }
    }
}

