using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer5Demo.Step2_Define_Subject_Interface;

namespace Observer5Demo.Step1_Define_Observer_Interface;

public interface IFan
{
    void Update(ICelebrity celebrity);
}