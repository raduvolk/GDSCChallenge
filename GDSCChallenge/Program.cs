using GDSCChallenge.Challenge;

Builder builder = new Builder();
Admin admin = builder.BuildAdmin();

WebApplication webApplication = new WebApplication("Web");

admin.AddApplications(webApplication);


User us1 = new User("Radu", "456456", "radu@gmail.com");
User us2 = new User("Valentin", "87876", "valentin@gmail.com");
User us3 = new User("Nikita", "t45g6", "nikita@gmail.com");

admin.AddUser(us1, webApplication);
admin.AddUser(us2, webApplication);
admin.AddUser(us3, webApplication);

webApplication.HttpRequest(us1);
admin.RemoveUser(us1, webApplication);