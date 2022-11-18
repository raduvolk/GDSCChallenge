namespace GDSCChallenge.Challenge;

public class MobileApplication : IApplication
{
    public readonly string name;
    private List<User> Users;
    public double rating { get;private set; } 

    public MobileApplication(string name)
    {
        this.name = name;
        Users = new List<User>();
    }

    public string GetName()
    {
        return name;
    }

    public int GetNumberOfUsers()
    {
        return Users.Count();
    }

    public void AddUser(User user)
    {
        foreach (var _user in Users)
        {
            if (_user.Email == user.Email)
            {
                Console.WriteLine($"Email: {user.Email} is already used");
                return;
            }
            if (_user.Username == user.Username)
            {
                Console.WriteLine($"Username: {user.Username} is already used");
                return;
            }
        }

        Users.Add(user);
    }

    public void RemoveUser(User user)
    {
        if (Users.Contains(user))
        {
            Users.Remove(user);
        }
    }

    public void SetRating()
    {
        rating = RateApp();
    }

    private double RateApp()
    {
        int sumOfRating = 0;
        foreach (var user in Users)
        {
            int rating;
            Console.Write($"Rating from {user.Username}: ");
            rating = Convert.ToInt32(Console.ReadLine());
            sumOfRating += rating;
        }

        return (double) sumOfRating / Users.Count;
    }
}