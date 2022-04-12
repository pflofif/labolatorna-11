using labolatorna_11.Artisans;

namespace labolatorna_11.Observer_Pattern
{
    public interface ISubject
    {
        void Attach(IObserverLaba subObj);
        void Detach(IObserverLaba subObj);
        void Notify();
    }
}