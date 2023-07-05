using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLLibrary
{
    //Астахов Максим 31 ИС
    public class Hobby : IComparable<Hobby>//класс хобби использльзование интерфейса ICompare
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Hobby(string name, string description)
        {
            Name = name;
            Description = description;
        }


        public void Show()
        {
            Console.WriteLine($"Хобби: название = {Name}, Описание = {Description}");//вывод на экран
        }
        public int CompareTo(Hobby other)
        {
            if (this.Description.Length > other.Description.Length) return 1;// название хобби длиннее
            if (this.Description.Length < other.Description.Length) return -1;//название хобби короче
            {
                return Name.CompareTo(other.Name);
            }
        }
    }
}
