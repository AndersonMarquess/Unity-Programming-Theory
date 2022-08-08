using UnityEngine;

namespace UnityProgrammingTheory.Scripts.Store.Electronic
{
    public class Smartphone : ElectronicStoreItem
    {
        [SerializeField]
        private string _itemName = "Smartphone";
        [SerializeField]
        private float _itemPrice = 499f;

        public override string GetName()
        {
            return _itemName;
        }

        public override float GetPrice()
        {
            return _itemPrice;
        }

        // POLYMORPHISM
        public override void PerformAction()
        {
            Debug.Log("Making calls");
        }
    }
}
