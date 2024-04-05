//	• Client code associates a builder with a director, then constructs and retrieves the product. 

using Builder3Demo.Step3_ConcreteBuilder;
using Builder3Demo.Step4_Director;

var director = new Director(new ConcreteBuilder());
director.Construct();
