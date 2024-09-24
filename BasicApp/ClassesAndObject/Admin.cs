 class Admin : Person{
    public Admin(string n,  DateTime d, char g, string r) : base(n, d, g)
    {   
        Role= r;  
    }
    public string Role="";
  
     public override void PrintDetails()
    {
        base.PrintDetails();
 Console.WriteLine($"\t\t{Role}");
      
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tRole";
        Console.WriteLine(header);
    }
    
}