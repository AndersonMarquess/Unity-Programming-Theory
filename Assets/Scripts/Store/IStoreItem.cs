namespace UnityProgrammingTheory.Scripts.Store
{
    // ABSTRACTION
    public interface IStoreItem
    {
        string GetName();

        float GetPrice();

        void ShowInfo();
    }
}
