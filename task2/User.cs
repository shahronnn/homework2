public class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    public string Password;
    public bool IsLoggedOn=false;

    public void Login(string username, string password)
    {
        if ( username == UserName && password == Password )
        {
            System.Console.WriteLine("User is logged successfully");
            IsLoggedOn = true;
        }
        else 
        {
            System.Console.WriteLine("Username or password is incorrect");
        }
    }
    public void LogOut()
    {
        IsLoggedOn = false;
    }
    public string GetFullInfo()
    {
        return  $"{FirstName} {LastName} - {IsLoggedOn}";
    }
}
