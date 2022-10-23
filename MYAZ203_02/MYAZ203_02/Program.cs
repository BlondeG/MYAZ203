using MYAZ203_02;

Employee employee1 = new Employee(0,"Sümeyye","Karlı");
Employee employee2 = new Employee(1, "Okan","Cevahir");
Employee employee3 = new Employee(2,"Melike","Karlı");

EmployeeManager employeeManager=new EmployeeManager();
employeeManager.AddEmployee(employee1);
employeeManager.AddEmployee(employee2);
employeeManager.AddEmployee(employee3);

employeeManager.RemoveEmployee(0);
employeeManager.RemoveEmployee(1);
Console.ReadLine();