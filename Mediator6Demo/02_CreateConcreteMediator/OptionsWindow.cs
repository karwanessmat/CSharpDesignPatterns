using Mediator6Demo._01_DefineMediatorInterface;
using Mediator6Demo._03_DefineComponentBaseClass;
using Mediator6Demo._04_CreateConcreteComponents;

namespace Mediator6Demo._02_CreateConcreteMediator
{
     public class OptionsWindow : IWindow
     {
          List dataList;
          Entry input;
          Button submitButton;

          public OptionsWindow()
          {
               dataList = new List(this);
               input = new Entry(this);
               submitButton = new Button(this);
          }

          public void Changed(Control control)
          {
              switch (control)
              {
                  case List:
                      input.Text = dataList.SelectedItem;
                      break;

                  case Entry:
                      submitButton.IsEnabled =
                          (!string.IsNullOrEmpty(input.Text));
                      break;
              }
          }

          public void Test()
          {
               dataList.SelectedItem = "Héctor";
               input.Text = "";
               Console.WriteLine($"Entry content: {input.Text}");
               Console.WriteLine($"Button state: {submitButton.IsEnabled}");
          }
     }
}
