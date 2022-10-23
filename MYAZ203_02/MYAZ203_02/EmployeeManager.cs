
using MYAZ203_02;

public class EmployeeManager
{
    public List<Employee> employees;

	public EmployeeManager()
	{
        employees = new List<Employee>();
    }

    public EmployeeManager(Employee employee)
    {
        employees = new List<Employee>();
        AddEmployee(employee);
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine($"Yeni çalışan eklendi");
    }

    public Employee RemoveEmployee(int id)
    {
        var emp = employees[id];
        employees.RemoveAt(id);
        return emp;
    }

}