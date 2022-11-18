namespace GDSCChallenge.Challenge;

public class Admin
{
    public string Name { get; private set; }

    private List<IApplication> apps;

    public Admin(string name)
    {
        Name = name;
        apps = new List<IApplication>();
    }

    public void AddApplications(IApplication app)
    {
        if (!apps.Contains(app)) apps.Add(app);
        else
        {
            Console.WriteLine("Aplicatia este in controlul adminului");
        }
    }

    public void AddUser(User user, IApplication app)
    {
        if (apps.Contains(app))
        {
            app.AddUser(user);
        }
        else
        {
            Console.WriteLine("Operatia nu se poate efectua");
        }

    }

    public void RemoveUser(User user, IApplication app)
    {
        if (apps.Contains(app))
        {
            app.RemoveUser(user);
        }
        else
        {
            Console.WriteLine("Operatia nu se poate efectua");
        }
    }

}