// <copyright file="MobileStatusBar.cs" company="Matt Lacey">
// Copyright (c) Matt Lacey. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the solution root for license information.
// </copyright>

using System;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UwpXamlHelper
{
    /// <summary>
    /// Represents the status bar of the device when run on mobile.
    /// </summary>
    public class MobileStatusBar : DependencyObject
    {
        /// <summary>
        /// Gets or sets whether the status bar is visible.
        /// </summary>
        public static readonly DependencyProperty IsVisibleProperty =
            DependencyProperty.RegisterAttached(
                "IsVisible",
                typeof(bool),
                typeof(Page),
                new PropertyMetadata(null, StatusBarChanged));

        /// <summary>
        /// Gets or sets the opacity of the background color of the status bar.
        /// </summary>
        public static readonly DependencyProperty BackgroundOpacityProperty =
            DependencyProperty.RegisterAttached(
                "BackgroundOpacity",
                typeof(double),
                typeof(Page),
                new PropertyMetadata(null, BackgroundOpacityChanged));

        /// <summary>
        /// Gets or sets the background color of the status bar. The alpha channel of the color is not used.
        /// </summary>
        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.RegisterAttached(
                "BackgroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, BackgroundColorChanged));

        /// <summary>
        /// Gets or sets the foreground color of the status bar. The alpha channel of the color is not used.
        /// </summary>
        public static readonly DependencyProperty ForegroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ForegroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ForegroundColorChanged));

#pragma warning disable 1591
        public static bool GetIsVisible(DependencyObject obj) => (bool)obj.GetValue(IsVisibleProperty);

        public static void SetIsVisible(DependencyObject obj, bool value) => obj.SetValue(IsVisibleProperty, value);

        public static double GetBackgroundOpacity(DependencyObject obj) => (double)obj.GetValue(BackgroundOpacityProperty);

        public static void SetBackgroundOpacity(DependencyObject obj, double value) => obj.SetValue(BackgroundOpacityProperty, value);

        public static Color GetBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(BackgroundColorProperty);

        public static void SetBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(BackgroundColorProperty, value);

        public static Color GetForegroundColor(DependencyObject obj) => (Color)obj.GetValue(ForegroundColorProperty);

        public static void SetForegroundColor(DependencyObject obj, Color value) => obj.SetValue(ForegroundColorProperty, value);

        private static async void StatusBarChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();

                if (statusBar != null)
                {
                    if ((bool)e.NewValue)
                    {
                        await statusBar.ShowAsync();
                    }
                    else
                    {
                        await statusBar.HideAsync();
                    }
                }
            }
        }

        private static void BackgroundOpacityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();

                if (statusBar != null)
                {
                    statusBar.BackgroundOpacity = (double)e.NewValue;
                }
            }
        }

        private static void BackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();

                if (statusBar != null)
                {
                    statusBar.BackgroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();

                if (statusBar != null)
                {
                    statusBar.ForegroundColor = (Color)e.NewValue;
                }
            }
        }
#pragma warning restore 1591
    }
}
