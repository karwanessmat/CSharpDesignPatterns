using AbstractFactory4Demo.Step3_Abstract_Factories;
using AbstractFactory4Demo.Step4_Concrete_Factories;
using AbstractFactory4Demo.Step5_Client;

var modernHouse = new House(new ModernHouseFactory());
modernHouse.DescribeHouse();


IHouseFactory victorianFactory = new VictorianHouseFactory();
House victorianHouse = new House(victorianFactory);
victorianHouse.DescribeHouse();