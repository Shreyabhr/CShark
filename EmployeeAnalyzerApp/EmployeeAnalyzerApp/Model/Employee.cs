using System;

namespace EmployeeAnalyzerApp.Model
{
    class Employee
    {
		private int _empId;
		private String _empName;
		private String _designation;
		private int _managerId;
		private String _dateOfJoining;
		private double _salary;
		private double _comission;
		private int _deptNo;

		public Employee(int empId, String empName, String designation, int managerId, String dateOfJoining, double salary, double comission, int deptNo)
		{
			_empId = empId;
			_empName = empName;
			_designation = designation;
			_managerId = managerId;
			_dateOfJoining = dateOfJoining;
			_salary = salary;
			_comission = comission;
			_deptNo = deptNo;
		}

		public int EmployeeId
        {
            get { return _empId; }
        }

		public string EmployeeName
		{
			get { return _empName; }
		}

		public string Designation
		{
			get { return _designation; }
		}

		public int ManagerId
		{
			get { return _managerId; }
		}

		public int DeptNo
		{
			get { return _deptNo; }
		}

		public string DOB
		{
			get { return _dateOfJoining; }
		}

		public double Salary
        {
            get { return _salary; }
        }
		public double Commission
		{
			get { return _comission; }
		}


	}
}
