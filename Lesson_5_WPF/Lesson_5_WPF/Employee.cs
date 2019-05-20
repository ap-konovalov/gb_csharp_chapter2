using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_WPF
{
    public class Employee
    {
        public int _id { get; set;}
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _patronymic { get; set; }
        private int _age { get; set;}

        public Employee(int Id,string FirstName, string LastName, string Patronymic, int Age)
        {
            _id = Id;
            _firstName = FirstName;
            _lastName = LastName;
            _patronymic = Patronymic;
            _age = Age;
        }

        public override string ToString()
        {
            return $"{_id}. {_firstName} {_lastName} {_patronymic} {_age}";
        }


        public ObservableCollection<Employee> employeesList = new ObservableCollection<Employee>();
        public void AddEmplyee()
        {
            employeesList.Add(new Employee(_id, _firstName, _lastName, _patronymic, _age));
        }
    }
}
