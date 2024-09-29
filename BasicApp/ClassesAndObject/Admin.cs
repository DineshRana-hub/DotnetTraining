 class Admin(string n,  DateTime d, char g, string r)  : Person(n, d, g){
   
    public string Role=r;
  
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