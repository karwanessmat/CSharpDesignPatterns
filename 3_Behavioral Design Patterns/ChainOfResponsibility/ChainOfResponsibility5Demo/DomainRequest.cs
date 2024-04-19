namespace ChainOfResponsibility5Demo;

public class DomainRequest(string userName, string password, string domain, string creditCardInfo)
{
    public string UserName { get; set; } = userName;
    public string Password { get; set; } = password;
    public string Domain { get; set; } = domain;
    public string CreditCardInfo { get; set; } = creditCardInfo;
}