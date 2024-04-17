

using Visitor5Demo._2_Create_Concrete_Visitors;
using Visitor5Demo._4__Implement_Concrete_Elements;

// concrete elements
var dog = new Dog();
var cat = new Cat();

// we have types of visitors 
var feedingVisitor = new FeedingVisitor();
var groomingVisitor = new GroomingVisitor();


//now each element must a visitor to run its implementation

dog.Accept(feedingVisitor);


cat.Name = "Test Name";
cat.Accept(groomingVisitor);

