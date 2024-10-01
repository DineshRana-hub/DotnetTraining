public class FileAndFolderHandeler{
    string FilePath=@"C:\C#\DotnetTraining\BasicApp\FileIO\Data\Student.txt";
    FileInfo fileInfo=>new(FilePath);
    public void CreateFile(){
       try{
        File.WriteAllText(FilePath,"Student detail.....");
        Console.WriteLine($"{fileInfo.Name} created successfully");
        }
        catch(IOException ex){
            Console.WriteLine(ex.Message);
        }
    }
     public void ReadFile(){
       
      var content=  File.ReadAllText(FilePath);
        Console.WriteLine(content);
    }
    public void CreateFolder(string newfolder){
        var folderpath=Path.Combine(fileInfo.DirectoryName, newfolder);
        Directory.CreateDirectory(folderpath);
    }
    
}