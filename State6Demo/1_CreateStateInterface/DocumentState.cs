using State6Demo._3_ContextClass;

namespace State6Demo._1_CreateStateInterface;
// Abstract State class
public abstract class DocumentState
{
    protected DocumentContext? Document;

    public void SetContext(DocumentContext document)
    {
        Document = document;
    }

    public abstract void HandleReview();
    public abstract void HandleApproval();
    public abstract void HandlePublish();
}
