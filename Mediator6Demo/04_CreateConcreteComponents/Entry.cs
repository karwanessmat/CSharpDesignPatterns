using Mediator6Demo._01_DefineMediatorInterface;
using Mediator6Demo._03_DefineComponentBaseClass;

namespace Mediator6Demo._04_CreateConcreteComponents
{
     public class Entry(IWindow owner) : Control(owner)
     {
          private string? text;

          public string Text
          {
               get => text;
               set{
                    text = value;
                    owner.Changed(this);
               }
          }
     }
}
