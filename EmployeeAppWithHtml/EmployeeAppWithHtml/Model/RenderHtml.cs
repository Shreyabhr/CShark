using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace EmployeeSalaryApp.Model
{
    class RenderHtml
    {
        public void RenderHtmlFile(List<Employee> employees)
        {
            foreach(Employee emp in employees)
            {
                string filename = emp.EmployeeId + ".html";
                CreateHtmlFile(filename);
                WriteToFile(emp, filename);
            }
        }

        private void WriteToFile(Employee emp, string filename)
        {
            
                var type = emp.GetType();
                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.WriteLine("<p>Designation: " + type.Name + "<p>");
                    PropertyInfo[] propInfos = type.GetProperties();
                    foreach (PropertyInfo method in propInfos)
                    {
                        sw.WriteLine("<p>" + method.Name + " :" + method.GetValue(emp, null) + "<p>");
                    }
                    sw.WriteLine("<p>CTC: " + emp.CalculateCTC());

                }
            
        }

        private void CreateHtmlFile(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                FileStream fs = File.Create(filename, 1024);
                fs.Close();
            }
        }
    }
}
