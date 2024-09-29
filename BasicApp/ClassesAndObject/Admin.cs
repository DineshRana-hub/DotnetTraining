
class Admin(string n,  DateTime d, char g, string dep)  : Person(n, d, g),IAdmin
 {
   
    public string department=dep;
  
     public override void PrintDetails()
    {
        base.PrintDetails();
 Console.WriteLine($"\t\t{dep}");
      
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Admin Name\t\tDate Of Birth\t\tGender\t\tdepartment";
        Console.WriteLine(header);
    }

    public List<string> GetRoles()=>["Attendence" , "Cirricular Activities"];
   
}