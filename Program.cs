using System;
using System.Collections.Generic;

namespace classes
{
   public class Program
    {
        static void Main(string[] args)
        {
            //DateTime newDate= DateTime.Now;
            Company acme= new Company("Acme Explosives", DateTime.Now);
            Employee newEmp= new Employee();
            newEmp.employeeName= "Jeff";
            newEmp.title="Cashier";
            newEmp.started= DateTime.Now;
            acme.addEmployee(newEmp);
            foreach(Employee x in acme.currentEmployees){
                Console.WriteLine($"{x.employeeName} {x.title} {x.started}");
            }
            
        }
    }
        public class Company
    {
        /*
            Some readonly properties
        */
        

        // Create a property for holding a list of current employees

    public List<Employee> currentEmployees= new List<Employee>();
        //currentEmployee.Add("Jeff ", "Cashier", DateTime.Now);

      // Create a method that allows external code to add an employee
      public void addEmployee(Employee newEmployee){
        currentEmployees.Add(newEmployee);
      }
      // Create a method that allows external code to remove an employee
      public void removeEmployee(Employee goneEmp){
        currentEmployees.Remove(goneEmp);
      }
        

        

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public string name {get;}
        public DateTime startDate {get;}
        public Company(string compName, DateTime createDate){
            name=compName;
            startDate= createDate;
        }

        }

        public class Employee{
       
            public string employeeName {get; set;}
            public string title {get; set;}
            public DateTime started {get;set;}
        }
   
}
