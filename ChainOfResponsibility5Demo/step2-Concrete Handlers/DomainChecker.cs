using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility5Demo.Step1_Interface;

namespace ChainOfResponsibility5Demo.step2_Concrete_Handlers;
    public class DomainChecker:Handler
    {
        public override bool ExecutedTask(DomainRequest request)
        {
            Console.WriteLine("Checking domain availability");
            var response = request.Domain == "domain.com";
            return response;
        }
    }