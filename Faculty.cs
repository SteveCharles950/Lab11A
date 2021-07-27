using System;


class Faculty : Person{
  public string Id { get; set;}
  public string Title { get; set;}
  public string college {get; set;}
  public string Employer { get; set;}
  public string YearlySalary { get; set;}
  public DateTime DateofEmployement { get; set; }
  public bool Tenured { get; set;}
  DateTime d1 = DateTime.Now;
  int Experience =0;



public Faculty () : base () {
   Console.WriteLine("faculty constructor");
    Title = "Instructor";
}

public Faculty(string fname, string lname): base(fname, lname){
  Console.WriteLine("faculty constructor");
  Title = "Instructor";
 
}


  public void Display()
  {
    Console.WriteLine(Id);
    Console.WriteLine(Title);
    Console.WriteLine(DateofEmployement);
    Console.WriteLine(Employer);
    Console.WriteLine(YearlySalary);
    Console.WriteLine(Tenured);
  }

public void GrantTenure()
        { 
           Experience = d1 - DateofEmployement;
          if (Experience >= 5){
           Tenured = true;
          }else{
           Tenured = false;}
        }


  public void promote()
   {
     if (Title == "Instructor" && Experience == 2)
     {
       Console.WriteLine("Faculty promoted to Assistant Professor rank");
     }
     else if (Title == "Assitant Professor" && Experience > 5)
     {
       Console.WriteLine("Faculty promoted to Associate rank");
     }
     else if (Title == "Associate Professor" && Experience > 10)
     {
       Console.WriteLine("Faculty promoted to Professor rank");
     }
     else
     {
       Console.WriteLine("No more promotion possible");
     }
   }
  
   public override void Intro()
   {
     base.Intro();
     Console.WriteLine("I work as " + (Title) + "at" + (college));
   }

}


    

  

