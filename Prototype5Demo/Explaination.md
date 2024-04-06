Here is a detailed `README.md` explaining the Prototype design pattern implementation in C#, including the complete code before and after refactoring:

---

# Prototype Design Pattern in C#

## Introduction

The Prototype design pattern is used to create duplicate objects while keeping performance in mind. It allows for copying an existing object, rather than creating a new instance from scratch, whenever the process is considered to be expensive.

## Implementation Before Refactoring

### Initial Code Structure

The initial code consists of an interface `ICampaign` and two concrete implementations: `TextCampaign` and `VideoCampaign`. The `CampaignManager` class has a method `Duplicate` to clone campaign objects.

#### ICampaign Interface

```csharp
namespace PrototypeDemo
{
    public interface ICampaign
    {
        decimal TotalBudget { get; set; }
        string CampaignName { get; set; }

        void StartCampaign();
        void PrintData();
    }
}
```

#### VideoCampaign Class

```csharp
namespace PrototypeDemo.SocialNetworks
{
    internal class VideoCampaign: ICampaign
    {
        public decimal TotalBudget { get; set; }
        public string CampaignName { get; set; }

        public void StartCampaign()
        {
            Console.WriteLine("Starting Video Campaign");
        }

        public void PrintData()
        {
            Console.WriteLine($"Campaign Name: {CampaignName}, Total Budget: {TotalBudget}");
        }
    }
}
```

#### CampaignManager Class

```csharp
namespace PrototypeDemo
{
    public class CampaignManager
    {
        public ICampaign Duplicate(ICampaign campaign)
        {
            ICampaign target = null;
            if (campaign is TextCampaign)
            {
                var source = (TextCampaign)campaign;
                target = new TextCampaign();
                target.TotalBudget = source.TotalBudget;
                target.CampaignName = source.CampaignName;
            }
            else if (campaign is VideoCampaign)
            {
                var source = (VideoCampaign)campaign;
                target = new VideoCampaign();
                target.TotalBudget = source.TotalBudget;
                target.CampaignName = source.CampaignName;
            }
            return target;
        }
    }
}
```

### Issues with Initial Approach

1. **Duplication Logic:** The `Duplicate` method in `CampaignManager` manually checks the type of campaign and creates a new instance accordingly, which is not scalable or efficient.
2. **Tightly Coupled:** The creation logic is tightly coupled with the concrete campaign classes.

## Implementation After Refactoring

### Refactored Code Structure

The refactoring introduces a `Clone` method in the `ICampaign` interface, which is implemented by each concrete campaign class. This method handles the cloning process, making the `CampaignManager` class's `Duplicate` method more straightforward.

#### ICampaign Interface

```csharp
public interface ICampaign
{
    decimal TotalBudget { get; set; }
    string CampaignName { get; set; }

    void StartCampaign();
    void PrintData();
    ICampaign Clone();
}
```

#### Concrete Campaign Classes

Each campaign class now includes a `Clone` method that creates a copy of itself.

```csharp
public class TextCampaign : ICampaign
{
    public decimal TotalBudget { get; set; }        
    public string CampaignName { get; set; }        

    public void StartCampaign() { /* Implementation */ }

    public void PrintData() { /* Implementation */ }

    public ICampaign Clone()
    {
        return new TextCampaign { TotalBudget = this.TotalBudget, CampaignName = this.CampaignName };
    }
}

internal class VideoCampaign : ICampaign
{
    public decimal TotalBudget { get; set; }
    public string CampaignName { get; set; }

    public void StartCampaign() { /* Implementation */ }

    public void PrintData() { /* Implementation */ }

    public ICampaign Clone()
    {
        return new VideoCampaign { TotalBudget = this.TotalBudget, CampaignName = this.CampaignName };
    }
}
```

#### CampaignManager Class

The `Duplicate` method now simply calls the `Clone` method of the provided campaign object.

```csharp
public class CampaignManager
{
    public ICampaign Duplicate(ICampaign campaign)
    {
        return campaign.Clone();
    }
}
```

### Benefits of Refactoring

- **Decoupling:** Campaign objects are now responsible for creating their copies, reducing dependencies.
- **Scalability:** Adding a new campaign type is easier as it only requires implementing the `Clone` method.
- **Maintainability:** The `Clone` method centralizes the copying logic in each class, making the code easier to manage and modify.

## Conclusion

Refactoring to the Prototype design pattern simplifies the duplication of objects and improves the code structure, making it more scalable, maintainable, and efficient. This pattern is particularly useful when the creation of an object is more expensive than copying an existing instance.

