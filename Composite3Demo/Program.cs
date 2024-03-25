using System;
using Composite3Demo.Component;
using Composite3Demo.Composite;
using Composite3Demo.Leaf;

namespace Composite3Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Node
            Employee leader1 =new TeamLead("Sabir",1000);
            leader1.Add(new TeamMember("Karwan",500));
           
            Employee leader2= new TeamLead("Ahmed",750);
            leader2.Add(new TeamMember("Payman",600));
            leader2.Add(new TeamMember("Samira",422));
            leader1.Add(leader2);


            Employee leader3= new TeamLead("Muhamad Tofiq",770);
            leader3.Add(new TeamMember("Samih",620));
            leader3.Add(new TeamMember("Hussein",710));
            leader2.Add(leader3);


            Console.WriteLine(leader1.GetData(1));


            Console.ReadKey();

        }
    }
}
