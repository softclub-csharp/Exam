using Task4;

var numbers = new List<int>() { 1, 2, 3, 4 };
var users = new List<User>()
{
    new User()
    {
        Firstname = "A",
        Lastname = "B",
        Username = "abc",
        Password = "abc"
    },
     new User()
    {
        Firstname = "A",
        Lastname = "B",
        Username = "abc",
        Password = "abc1"
    },
     new User()
    {
        Firstname = "A",
        Lastname = "B",
        Username = "abc",
        Password = "abc2"
    },
     new User()
    {
        Firstname = "A",
        Lastname = "B",
        Username = "abc",
        Password = "abc3"
    }
};


while (true)
{
    System.Console.Write("Username :");
    string username = Console.ReadLine();

    System.Console.Write("Password :");
    string password = Console.ReadLine();
    bool found = false;
    foreach (var user in users)
    {
        var result = user.Login(username, password);
        if (result == true)
        {
            found = true;
            System.Console.WriteLine($"Welocome {user.GetInfo()}");
            break;
        }
    }
    if (found == false)
    {
        System.Console.WriteLine("Wrong username or password");
    }
}