using System;

class MainClass {
  public static void Main (string[] args) {
    
    Faculty fac1 = new Faculty();
    fac1.FirstName = "Kara";
    fac1.LastName="Kaiser";
    fac1.Title = "professor";
    fac1.Employer ="IBM";
    fac1.YearlySalary="55000.00";
    fac1.DateofEmployement = Convert.ToDateTime("01/01/1989");
    fac1.GrantTenure();
    fac1.Display();


  }
}