// <copyright file="DesktopTitleBar.cs" company="Matt Lacey">
// Copyright (c) Matt Lacey. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the solution root for license information.
// </copyright>

using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UwpXamlHelper
{
    /// <summary>
    /// Represents the title bar of an app when run on desktop.
    /// </summary>
    public class DesktopTitleBar : DependencyObject
    {
        /// <summary>
        /// Gets or sets the color of the title bar foreground.
        /// </summary>
        public static readonly DependencyProperty ForegroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ForegroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ForegroundColorChanged));

        /// <summary>
        /// Gets or sets the color of the title bar background.
        /// </summary>
        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.RegisterAttached(
                "BackgroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, BackgroundColorChanged));

        /// <summary>
        /// Gets or sets the background color of the title bar buttons.
        /// </summary>
        public static readonly DependencyProperty ButtonBackgroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonBackgroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonBackgroundColorChanged));

        /// <summary>
        /// Gets or sets the foreground color of the title bar buttons.
        /// </summary>
        public static readonly DependencyProperty ButtonForegroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonForegroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonForegroundColorChanged));

        /// <summary>
        /// Gets or sets the background color of a title bar button when the pointer is over it.
        /// </summary>
        public static readonly DependencyProperty ButtonHoverBackgroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonHoverBackgroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonHoverBackgroundColorChanged));

        /// <summary>
        /// Gets or sets the foreground color of a title bar button when the pointer is over it.
        /// </summary>
        public static readonly DependencyProperty ButtonHoverForegroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonHoverForegroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonHoverForegroundColorChanged));

        /// <summary>
        /// Gets or sets the background color of a title bar button when it's inactive.
        /// </summary>
        public static readonly DependencyProperty ButtonInactiveBackgroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonInactiveBackgroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonInactiveBackgroundColorChanged));

        /// <summary>
        /// Gets or sets the foreground color of a title bar button when it's inactive.
        /// </summary>
        public static readonly DependencyProperty ButtonInactiveForegroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonInactiveForegroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonInactiveForegroundColorChanged));

        /// <summary>
        /// Gets or sets the background color of a title bar button when it's pressed.
        /// </summary>
        public static readonly DependencyProperty ButtonPressedBackgroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonPressedBackgroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonPressedBackgroundColorChanged));

        /// <summary>
        /// Gets or sets the foreground color of a title bar button when it's pressed.
        /// </summary>
        public static readonly DependencyProperty ButtonPressedForegroundColorProperty =
            DependencyProperty.RegisterAttached(
                "ButtonPressedForegroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, ButtonPressedForegroundColorChanged));

        /// <summary>
        /// Gets or sets the color of the title bar background when it's inactive.
        /// </summary>
        public static readonly DependencyProperty InactiveBackgroundColorProperty =
            DependencyProperty.RegisterAttached(
                "InactiveBackgroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, InactiveBackgroundColorChanged));

        /// <summary>
        /// Gets or sets the color of the title bar foreground when it's inactive.
        /// </summary>
        public static readonly DependencyProperty InactiveForegroundColorProperty =
            DependencyProperty.RegisterAttached(
                "InactiveForegroundColor",
                typeof(Color),
                typeof(Page),
                new PropertyMetadata(null, InactiveForegroundColorChanged));

#pragma warning disable 1591
        public static Color GetForegroundColor(DependencyObject obj) => (Color)obj.GetValue(ForegroundColorProperty);

        public static void SetForegroundColor(DependencyObject obj, Color value) => obj.SetValue(ForegroundColorProperty, value);

        public static Color GetBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(BackgroundColorProperty);

        public static void SetBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(BackgroundColorProperty, value);

        public static Color GetButtonHoverForegroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonHoverForegroundColorProperty);

        public static void SetButtonHoverForegroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonHoverForegroundColorProperty, value);

        public static Color GetButtonBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonBackgroundColorProperty);

        public static void SetButtonBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonBackgroundColorProperty, value);

        public static Color GetButtonForegroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonForegroundColorProperty);

        public static void SetButtonForegroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonForegroundColorProperty, value);

        public static Color GetButtonHoverBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonHoverBackgroundColorProperty);

        public static void SetButtonHoverBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonHoverBackgroundColorProperty, value);

        public static Color GetButtonInactiveBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonInactiveBackgroundColorProperty);

        public static void SetButtonInactiveBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonInactiveBackgroundColorProperty, value);

        public static Color GetButtonInactiveForegroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonInactiveForegroundColorProperty);

        public static void SetButtonInactiveForegroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonInactiveForegroundColorProperty, value);

        public static Color GetButtonPressedBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonPressedBackgroundColorProperty);

        public static void SetButtonPressedBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonPressedBackgroundColorProperty, value);

        public static Color GetInactiveBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(InactiveBackgroundColorProperty);

        public static void SetInactiveBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(InactiveBackgroundColorProperty, value);

        public static Color GetInactiveForegroundColor(DependencyObject obj) => (Color)obj.GetValue(InactiveForegroundColorProperty);

        public static void SetInactiveForegroundColor(DependencyObject obj, Color value) => obj.SetValue(InactiveForegroundColorProperty, value);

        public static Color GetButtonPressedForegroundColor(DependencyObject obj) => (Color)obj.GetValue(ButtonPressedForegroundColorProperty);

        public static void SetButtonPressedForegroundColor(DependencyObject obj, Color value) => obj.SetValue(ButtonPressedForegroundColorProperty, value);

        private static void ForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ForegroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void BackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.BackgroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonHoverForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonHoverForegroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonBackgroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonForegroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonHoverBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonHoverBackgroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonInactiveForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonInactiveForegroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonInactiveBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonInactiveBackgroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonPressedBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonPressedBackgroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void InactiveBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.InactiveBackgroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void InactiveForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.InactiveForegroundColor = (Color)e.NewValue;
                }
            }
        }

        private static void ButtonPressedForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonPressedForegroundColor = (Color)e.NewValue;
                }
            }
        }
#pragma warning restore 1591
    }
}
