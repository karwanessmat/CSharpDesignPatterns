using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer4Demo.Subject;

namespace Observer4Demo.Observer
{
    public interface IRestaurant
    {
        void Update(Vegetable vegetable);
    }
}
