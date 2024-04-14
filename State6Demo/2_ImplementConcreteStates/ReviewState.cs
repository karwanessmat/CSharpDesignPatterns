using State6Demo._1_CreateStateInterface;

namespace State6Demo._2_ImplementConcreteStates;

public class ReviewState : DocumentState
{
    public override void HandleReview()
    {
        Console.WriteLine("Document is already in review.");
    }

    public override void HandleApproval()
    {
        Console.WriteLine("Document approved.");
        Document.SetState(new ApprovedState());
    }

    public override void HandlePublish()
    {
        Console.WriteLine("Reviewed document cannot be published without approval.");
    }
}