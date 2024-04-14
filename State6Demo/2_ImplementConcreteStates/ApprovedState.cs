using State6Demo._1_CreateStateInterface;

namespace State6Demo._2_ImplementConcreteStates;

public class ApprovedState : DocumentState
{
    public override void HandleReview()
    {
        Console.WriteLine("Approved document cannot be sent back for review directly.");
    }

    public override void HandleApproval()
    {
        Console.WriteLine("Document is already approved.");
    }

    public override void HandlePublish()
    {
        Console.WriteLine("Document published.");
        Document!.TransitionTo(new PublishedState());
    }
}