namespace GDSCChallenge.Challenge;

public class User
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public string Email { get; private set; }

    public User(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }

    string GetMail()
    {
        return Email;
    }

    void ChangePassword(string newPassword)
    {
        Password = newPassword;
    }

    public override string ToString()
    {
        return $"User: {Username} {Email}";
    }
}