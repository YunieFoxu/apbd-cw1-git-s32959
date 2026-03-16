namespace apbd_cw1_git_s32959;

public class Student
{
    public string Name { get; set;}
    public string Surname { get; set;}
    public string SNumber { get;}
    public Student(string name, string surname, string snumber)
    {
        this.Name = name;
        this.Surname = surname;
        this.SNumber = snumber;
    }
}