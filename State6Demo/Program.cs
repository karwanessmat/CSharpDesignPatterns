using State6Demo._2_ImplementConcreteStates;
using State6Demo._3_ContextClass;

var document = new DocumentContext(new DraftState());
document.Review(); // Sends for review
document.Approve(); // Approves the document
document.Publish(); // Publishes the document