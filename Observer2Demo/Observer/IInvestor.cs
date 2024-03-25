using Observer2Demo.Subject;

namespace Observer2Demo.Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
