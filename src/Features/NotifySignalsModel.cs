using System;
using Qml.Net;

namespace Features
{
    public class NotifySignalsModel
    {
        private string _bindableProperty = "";
        
        [NotifySignal]
        public string BindableProperty
        {
            get
            {
                return _bindableProperty;
            }
            set
            {
                if (_bindableProperty == value)
                {
                    // No signal is raised, Qml doesn't update any bound properties.
                    return;
                }

                _bindableProperty = value;
                this.ActivateSignal("bindablePropertyChanged");
            }
        }

        public void ChangeBindableProperty()
        {
            BindableProperty = DateTime.Now.ToLongTimeString();
        }
    }
}