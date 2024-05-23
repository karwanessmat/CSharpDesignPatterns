namespace Observer1Demo.Step1_Define_Observer_Interface;

/// <summary>
/// 1. Define the Observer Interface: This interface allows the Subject to communicate with its observers when its state changes.
/// </summary>
public abstract class Observer
{
    public abstract void Update();
}