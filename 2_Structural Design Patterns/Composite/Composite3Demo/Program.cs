using System;
using Composite3Demo._2.Leaf;
using Composite3Demo._3.Composite;

namespace Composite3Demo;

class Program
{
    static void Main(string[] args)
    {

        var leader1 = new TeamLead("Sabir", 1000);
        leader1.Add(new TeamMember("Karwan", 500));

        var leader2 = new TeamLead("Ahmed", 750);
        leader2.Add(new TeamMember("Payman", 600));
        leader2.Add(new TeamMember("Samira", 422));
        leader1.Add(leader2);

        var leader3 = new TeamLead("Muhamad Tofiq", 770);
        leader3.Add(new TeamMember("Samih", 620));
        leader3.Add(new TeamMember("Hussein", 710));
        leader2.Add(leader3);

        var leader4 = new TeamLead("Leader4", 4);
        leader4.Add(new TeamMember("Member4-1",41));
        leader4.Add(new TeamMember("Member4-2",42));
        leader1.Add(leader4);


        leader1.GetData(0);
        Console.WriteLine();
        Console.WriteLine();

        var leader11 = new TeamLead("Sabir", 1000);
        leader11.Add(new TeamMember("Karwan", 500));

        var leader22 = new TeamLead("Ahmed", 750);
        leader22.Add(new TeamMember("Payman", 600));
        leader22.Add(new TeamMember("Samira", 422));
        leader11.Add(leader22);

        var leader33 = new TeamLead("Muhamad Tofiq", 770);
        leader33.Add(new TeamMember("Samih", 620));
        leader33.Add(new TeamMember("Hussein", 710));
        leader22.Add(leader33);

        var leader44 = new TeamLead("Leader4", 4);
        leader44.Add(new TeamMember("Member4-1", 41));
        leader44.Add(new TeamMember("Member4-2", 42));
        leader11.Add(leader44);

        leader11.GetData(0);

        Console.ReadKey();

    }
}