using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy3Demo
{


    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    internal abstract class Subject
    {
        public abstract void Request();
    }

    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    internal class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }

    /// <summary>
    /// The 'Proxy' class
    /// </summary>
    internal class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            //// Use 'lazy initialization'
            //if (_realSubject == null)
            //{
            //    _realSubject = new RealSubject();
            //}
            //_realSubject.Request();


            // Use 'lazy initialization'
            _realSubject ??= new RealSubject();
            _realSubject.Request();
        }
    }
}
