using System;
using Qml.Net;

namespace Features
{
    [Signal("customSignal", NetVariantType.String)]
    public class SignalsModel
    {
        public void RaiseSignal()
        {
            this.ActivateSignal("customSignal", $"Signal was raised from .NET at {DateTime.Now.ToLongTimeString()}");
        }
    }
}