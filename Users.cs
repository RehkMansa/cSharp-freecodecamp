class Users
{
  public string name; public string role; public int age;
  private string officeRole = ""; public static int userCount = 0;
  public Users(
    string _name,
    string _role,
    int _age,
    string _officeRole)
  {
    name = _name;
    role = _role;
    age = _age;
    OfficeRole = _officeRole;
    userCount++;
  }
  public string UserRole()
  {
    return name + " has the role of " + officeRole;
  }

  public int GetUserCount()
  {
    return userCount;
  }

  public string OfficeRole
  {
    get { return officeRole; }

    set
    {
      switch (value)
      {
        case "engineering":
        case "design":
        case "product":
          officeRole = value;
          break;
        default:
          officeRole = "others";
          break;
      }
    }
  }


}