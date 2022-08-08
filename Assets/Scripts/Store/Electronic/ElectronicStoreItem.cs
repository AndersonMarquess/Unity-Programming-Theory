using UnityEngine;

namespace UnityProgrammingTheory.Scripts.Store.Electronic
{
    // INHERITANCE
    public abstract class ElectronicStoreItem : MonoBehaviour, IStoreItem
    {
        // ENCAPSULATION
        private bool _isOn = false;

        private void OnMouseDown()
        {
            TurnOn();
            ShowInfo();
            PerformAction();
            TurnOff();
            TurnOff();
        }

        public virtual string GetName()
        {
            return "Generic Electronic";
        }

        public virtual float GetPrice()
        {
            return float.MinValue;
        }

        public virtual void ShowInfo()
        {
            Debug.Log($"A {GetName()} costing ${GetPrice():N2}");
        }

        public virtual void PerformAction()
        {
            Debug.Log($"Performing generic electronic action");
        }

        protected virtual void TurnOn()
        {
            DebugOnOffState(true);
        }

        private void DebugOnOffState(bool shouldTurnOn)
        {
            string onStateTxt = shouldTurnOn ? "on" : "off";
            Debug.Log($"Trying to turn {onStateTxt}");

            if (_isOn == shouldTurnOn)
            {
                Debug.Log($"{GetName()} is already {onStateTxt}");
                return;
            }

            _isOn = shouldTurnOn;
            Debug.Log($"{GetName()} is {onStateTxt}");
        }

        protected virtual void TurnOff()
        {
            DebugOnOffState(false);
        }
    }
}
