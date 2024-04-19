using Mediator6Demo._01_DefineMediatorInterface;
using Mediator6Demo._03_DefineComponentBaseClass;

namespace Mediator6Demo._04_CreateConcreteComponents
{
     public class List(IWindow owner) : Control(owner)
     {
          private string selectedItem;

          public string SelectedItem
          {
               get => selectedItem; 
               set
               {
                    selectedItem = value;
                    owner.Changed(this);
               }
          }
     }
}
