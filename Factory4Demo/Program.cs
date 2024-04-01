using Factory4Demo.Concrete_Creator_Classes;
using Factory4Demo.Creator_Class;

LogisticProviderFactory logistics = new RoadLogisticProviderFactory();
logistics.PlanDelivery();

logistics = new AirLogisticProviderFactory();
logistics.PlanDelivery();


logistics = new SeaLogisticProviderFactory();
logistics.PlanDelivery();
