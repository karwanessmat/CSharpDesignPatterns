using Observer1Demo.Step2_Define_Subject_Interface;

namespace Observer1Demo.Step3_Implement_Concrete_Subject
{
    /// <summary>
    /// Step3: Create Concrete Subject Class: This class implements the Subject interface. It maintains a list of its observers and communicates with them as needed.
    /// </summary>
    public class ConcreteSubject : Subject
    {
        // Gets or sets subject state
        public string SubjectState { get; set; }
    }
}
