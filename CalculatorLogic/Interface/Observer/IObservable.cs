namespace CalculatorLogic.Interface.Observer
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Notify();
    }
}
