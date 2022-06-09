namespace ViewModelFun.Models;

public class User
{
  public string FirstName { get; set; } = null!;
  public string LastName { get; set; } = null!;

  public User(string fName, string lName)
  {
    FirstName = fName;
    LastName = lName;
  }
}