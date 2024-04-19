using State6Demo._1_CreateStateInterface;

namespace State6Demo._3_ContextClass;

// Context class
public class DocumentContext
{
    private DocumentState _state;

    public DocumentContext(DocumentState state)
    {
        _state = state;
        TransitionTo(state);
    }

    public void TransitionTo(DocumentState state)
    {
        Console.WriteLine($"Transitioning to {state.GetType().Name}");
        _state = state;
        _state.SetContext(this);
    }

    public void Review()
    {
        _state.HandleReview();
    }

    public void Approve()
    {
        _state.HandleApproval();
    }

    public void Publish()
    {
        _state.HandlePublish();
    }
}