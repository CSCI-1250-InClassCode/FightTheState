using System.Runtime.CompilerServices;

namespace FightTheState
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public DateTime DOB { get; set; }

        public bool Happy { get; private set; }



        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = DateTime.Now;
            Happy = true;

        }


        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string ToDelimtedFileFormater(char delimiter = ',')
        {
            return $"{FirstName}{delimiter}{LastName}{delimiter}{DOB}{delimiter}{Happy}";
        }

        public static string CSVHeader(char delimeter = ',')
        {
            string header = string.Empty;

            for (int i = 0; i < typeof(Person).GetProperties().Length; i++)
            {
                header += typeof(Person).GetProperties()[i].Name;
                if(i != typeof(Person).GetProperties().Length - 1)
                {
                    header += delimeter;
                }
            }

            return header ;
        }

    }
}