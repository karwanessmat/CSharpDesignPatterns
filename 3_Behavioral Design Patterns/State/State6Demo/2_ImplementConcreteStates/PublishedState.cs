using State6Demo._1_CreateStateInterface;

namespace State6Demo._2_ImplementConcreteStates;
// Concrete State classes

public class PublishedState : DocumentState
{
    public override void HandleReview()
    {
        Console.WriteLine("Published document cannot be reviewed.");
    }

    public override void HandleApproval()
    {
        Console.WriteLine("Published document cannot be approved.");
    }

    public override void HandlePublish()
    {
        Console.WriteLine("Document is already published.");
    }
}