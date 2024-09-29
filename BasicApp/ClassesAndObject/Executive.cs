 class Executive (string n, DateTime d, char g): Person(n,d,g), IAdmin
  {
    public List<string> GetRoles()=> ["Counsilling", "budgeting"];

}