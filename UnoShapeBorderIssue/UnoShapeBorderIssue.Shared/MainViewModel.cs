// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2022 All rights reserved</copyright>

namespace UnoShapeBorderIssue
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Text;

    /// <summary>
    /// The main view model.
    /// </summary>
    [Bindable(bindable: true)]
    public class MainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Multicast event for property change notifications.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the button width.
        /// </summary>
        public double ButtonWidth { get; private set; }

        /// <summary>
        /// Gets the button height.
        /// </summary>
        public double ButtonHeight { get; private set; }

        /// <summary>
        /// Gets the number of times the button height has changed.
        /// </summary>
        public int ButtonHeightChanged { get; private set; }

        public void SetButtonSize(double width, double height)
        {
            if (this.ButtonWidth != width)
            {
                this.ButtonWidth = width;
                this.OnPropertyChanged(nameof(this.ButtonWidth));
            }

            if (this.ButtonHeight != height)
            {
                this.ButtonHeight = height;
                this.ButtonHeightChanged++;
                this.OnPropertyChanged(nameof(this.ButtonHeight));
                this.OnPropertyChanged(nameof(this.ButtonHeightChanged));
            }
        }

        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property used to notify listeners.  This
        /// value is optional and can be provided automatically when invoked from compilers
        /// that support <see cref="CallerMemberNameAttribute"/>.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            try
            {
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(string.Format("Exception {0}", ex.Message));
#endif
            }
        }
    }
}
