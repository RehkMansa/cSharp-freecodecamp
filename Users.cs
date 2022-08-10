class Users
{
  public string name; public string role; public int age;
  private string officeRole = "";
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
  }
  public string UserRole()
  {
    return name + " has the role of " + officeRole;
  }

  public string OfficeRole
  {
    get { return officeRole; }

    set
    {
      if (value == "engineering" || value == "design" || value == "product")
      {
        officeRole = value;
      }
      else
      {
        officeRole = "others";
      }
    }
  }


}