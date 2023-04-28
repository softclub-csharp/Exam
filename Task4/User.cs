namespace Task4;

public class User
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }


    public bool Login(string username, string password)
    {
        if (Username == username && Password == password)
        {  
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetInfo()
    {
        return $"{Firstname} {Lastname}";
    }
}
