namespace Adapter5Demo.Step3_Client___Adaptee;

/// <summary>
/// The 'Adaptee' class
/// </summary>
public class HrSystem
{
    public string[][] GetEmployees()
    {
        var employees = new string[4][];

        employees[0] = ["100", "Deepak", "Team Leader"];
        employees[1] = ["101", "Rohit", "Developer"];
        employees[2] = ["102", "Gautam", "Developer"];
        employees[3] = ["103", "Dev", "Tester"];

        return employees;
    }
}