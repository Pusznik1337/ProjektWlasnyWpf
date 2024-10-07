using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWlasny
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public ObservableCollection<int?> Grades { get; set; }
        public string Pesel {  get; set; }


        public Student(int id, string name, string lastname, ObservableCollection<int?> grades, string pesel)
        {
            this.Id = id;
            this.Name = name;
            this.Lastname = lastname;
            this.Grades = grades;
            this.Pesel = pesel;
        }

        public Student(int id, string name, string lastname, string pesel)
        {
            this.Id = id;
            this.Name = name;
            this.Lastname = lastname;
            this.Grades = new ObservableCollection<int?>{ };
            this.Pesel = pesel;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Id, Name, Lastname);
        }
    }
}
