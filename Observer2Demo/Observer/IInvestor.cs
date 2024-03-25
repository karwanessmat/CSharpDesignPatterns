using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer2Demo.Subject;

namespace Observer2Demo.Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
