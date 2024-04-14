
using Visitor6Demo;
using Visitor6Demo._2_Create_Concrete_Visitors;
using Visitor6Demo._4__Implement_Concrete_Elements;

var frm1 = new Form();

frm1.AddItem(new Button("btn1"));
frm1.AddItem(new TextBox("txt1"));
frm1.AddItem(new TextBox("txt2"));
frm1.AddItem(new Button("btn2"));

frm1.Execute(new DisableOperation());
frm1.Execute(new EnableOperation());