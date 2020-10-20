﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using AppKit;
using Playground.Core.ViewModels;
using System.Linq;
using MvvmCross.Platforms.Mac.Presenters.Attributes;
using MvvmCross.Platforms.Mac.Views;
using MvvmCross.ViewModels;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;

namespace Playground.Mac
{
    [MvxFromStoryboard("Main")]
    [MvxWindowPresentation(PositionX = 300)]
    public partial class RootView : MvxViewController<RootViewModel>, IMvxOverridePresentationAttribute
    {
        public bool MyValue { get; set; } = true;

        public RootView(IntPtr handle) : base(handle)
        {
            Title = "Root view";
        }

        public override void LoadView()
        {
            base.LoadView();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = CreateBindingSet();
            set.Bind(btnChild).To(vm => vm.ShowChildCommand);
            set.Bind(btnModal).To(vm => vm.ShowModalCommand);
            set.Bind(btnSheet).To(vm => vm.ShowSheetCommand);
            set.Bind(btnWindow).To(vm => vm.ShowWindowCommand);
            set.Bind(btnTabs).To(vm => vm.ShowTabsCommand);
            set.Apply();
        }

        public override void ViewDidDisappear()
        {
            base.ViewDidDisappear();
        }

        public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
        {
            if (!NSApplication.SharedApplication.DangerousWindows.Any())
                return null;

            return new MvxContentPresentationAttribute
            {
                WindowIdentifier = typeof(RootView).Name
            };
        }
    }
}
