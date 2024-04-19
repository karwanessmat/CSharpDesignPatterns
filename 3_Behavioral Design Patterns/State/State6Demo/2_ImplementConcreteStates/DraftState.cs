
using State6Demo._1_CreateStateInterface;

namespace State6Demo._2_ImplementConcreteStates;

public class DraftState : DocumentState
{
    public override void HandleReview()
    {
        Console.WriteLine("Document sent for review.");
        Document.TransitionTo(new ReviewState());
    }

    public override void HandleApproval()
    {
        Console.WriteLine("Draft cannot be approved directly.");
    }

    public override void HandlePublish()
    {
        Console.WriteLine("Draft cannot be published directly.");
    }
}