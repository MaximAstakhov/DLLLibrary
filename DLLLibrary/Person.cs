using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DLLLibrary
{
    public class Person
    {
        //Астахов Максим 31 ИС
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Hobby> Hobbbies = new List<Hobby>();

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void ShowAll()
        {
            Console.WriteLine($"Человек: имя = {Name}, адрес = {Address}");//вывод на экран
            Hobbbies.Sort();// сортировка
            foreach (Hobby hobby in Hobbbies)
            {
                hobby.Show();
            }
        }
    }
}

