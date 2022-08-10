class Users
{
  public string name; public string role; public int age;
  public Users(string _name, string _role, int _age)
  {
    name = _name;
    role = _role;
    age = _age;
  }

  public string UserRole()
  {
    return name + " has the role of " + role;
  }
}