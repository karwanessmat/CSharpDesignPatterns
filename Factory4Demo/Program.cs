using Factory4Demo.Step3_Creator;
using Factory4Demo.step4_ConcreteCreator;

LogisticProviderFactory logistics = new RoadLogisticProviderFactory();
logistics.PlanDelivery();

logistics = new AirLogisticProviderFactory();
logistics.PlanDelivery();


logistics = new SeaLogisticProviderFactory();
logistics.PlanDelivery();
