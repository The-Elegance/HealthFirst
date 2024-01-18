﻿using System.Windows;
using System.Windows.Documents;

namespace HealthFirst.WPF.Extensions
{
    public static class TextBlock
    {
        public static readonly DependencyProperty TextByKeyProperty
            = DependencyProperty.RegisterAttached("TextByKey", typeof(string), typeof(TextBlock),
                new FrameworkPropertyMetadata(string.Empty, OnTextByKeyChanged));

        public static readonly DependencyProperty RunByKeyProperty
    = DependencyProperty.RegisterAttached("RunByKey", typeof(string), typeof(TextBlock),
        new FrameworkPropertyMetadata(string.Empty, OnRunByKeyChanged));

        public static void SetTextByKey(DependencyObject dp, string value)
        {
            dp.SetValue(TextByKeyProperty, value);
        }

        public static string GetTextByKey(DependencyObject dp)
        {
            return (string)dp.GetValue(TextByKeyProperty);
        }

        private static void OnTextByKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is System.Windows.Controls.TextBlock)
            {
                var textBlock = d as System.Windows.Controls.TextBlock;
                textBlock.SetResourceReference(System.Windows.Controls.TextBlock.TextProperty, e.NewValue);
            }
        }

        public static void SetRunByKey(DependencyObject dp, string value)
        {
            dp.SetValue(TextByKeyProperty, value);
        }

        public static string GetRunByKey(DependencyObject dp)
        {
            return (string)dp.GetValue(TextByKeyProperty);
        }

        private static void OnRunByKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Run)
            {
                var run = d as Run;
                run.SetResourceReference(Run.TextProperty, e.NewValue);
            }
        }
    }
}
