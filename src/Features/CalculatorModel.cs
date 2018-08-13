using Qml.Net;
using System;

namespace Features
{
    public class CalculatorModel
    {
        private bool _isValid = false;
        private string _computedResult = "";

        [NotifySignal]
        public string ComputedResult
        {
            get
            {
                return _computedResult;
            }
            set
            {
                if (_computedResult == value)
                {
                    // No signal is raised, Qml doesn't update any bound properties.
                    return;
                }

                _computedResult = value;
                this.ActivateSignal("computedResultChanged");
            }
        }

        [NotifySignal]
        public bool IsValid
        {
            get
            {
                return _isValid;
            }
            set
            {
                if (_isValid == value)
                {
                    // No signal is raised, Qml doesn't update any bound properties.
                    return;
                }

                _isValid = value;
                this.ActivateSignal("isValidChanged");
            }
        }

        public void Add(string inputValue1, string inputValue2)
        {
            ComputedResult = Convert.ToString(decimal.Parse(inputValue1) + decimal.Parse(inputValue2));
        }

        public void Subtract(string inputValue1, string inputValue2)
        {
            ComputedResult = Convert.ToString(decimal.Parse(inputValue1) - decimal.Parse(inputValue2));
        }

        public void Multiply(string inputValue1, string inputValue2)
        {
            ComputedResult = Convert.ToString(decimal.Parse(inputValue1) * decimal.Parse(inputValue2));
        }

        public void Divide(string inputValue1, string inputValue2)
        {
            var value1 = decimal.Parse(inputValue1);
            var value2 = decimal.Parse(inputValue2);

            if (value2 == 0)
            {
                ComputedResult = $"Cannot devide by zero.";
                return;
            }

            ComputedResult = Convert.ToString(value1 / value2);
        }
    }
}