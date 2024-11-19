using ChainOfResponsibility5Demo.Step1_Interface;

namespace ChainOfResponsibility5Demo.step2_Concrete_Handlers;
    public class DomainChecker:Handler
    {
        public override bool ExecutedTask(DomainRequest request)
        {
            Console.WriteLine("Checking domain availability");
            bool response = request.Domain == "domain.com";
            if (response)
            {
                Console.WriteLine("Domain is available");
                Console.WriteLine("_________");

}
        return response;
        }
    }