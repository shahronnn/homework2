var user1 = new User();
user1.FirstName = "Shahrom";
user1.LastName = "Sultonalizoda";
user1.UserName = "shahronnn";
user1.Password = "1111";

System.Console.WriteLine("Login : ");
System.Console.Write("Enter your username : ");
var username = Console.ReadLine();
System.Console.Write("Enter your password : ");
var pass = Console.ReadLine();

user1.Login(username, pass);
System.Console.WriteLine("---------------------");
System.Console.WriteLine(user1.GetFullInfo());
user1.LogOut();
System.Console.WriteLine(user1.GetFullInfo());