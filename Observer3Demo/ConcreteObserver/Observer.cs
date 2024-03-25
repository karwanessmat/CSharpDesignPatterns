using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer3Demo.Observer;
using Observer3Demo.Subject;

namespace Observer3Demo.ConcreteObserver
{
    public class Observer: IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void Update(string availability)
        {
            Console.WriteLine($"Hello {UserName} product is now {availability} on High Plan");
        }
    }
}
