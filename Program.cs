namespace FightTheState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[32];

            numbers[0] = 1;


            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = i;
            }

            int[] numbersnew = new int[33];

            for (int i = 0;i < numbers.Length;i++)
            {
                numbersnew[i] = numbers[i];
            }

            //get the last one into numbersnew

            numbersnew[numbersnew.Length - 1] = int.Parse(Console.ReadLine()); // new value you want to get int

            List<int> listOfNumbers = new List<int>();

            for (int i = 0;i < listOfNumbers.Count ; i++) 
            {
                listOfNumbers.Add(listOfNumbers[i]);
            }

            Console.WriteLine(listOfNumbers[listOfNumbers.Count - 1]);

            listOfNumbers.Add(12);
            */

            KeyValuePair<int, string> pair = new KeyValuePair<int, string>(1, "one");

           


            Dictionary<int, string> mydictionary = new Dictionary<int, string>();



            mydictionary.Add(1, "one");
            mydictionary.Add(2, "two");
            mydictionary.Add(3, "three");

            Console.WriteLine(mydictionary[3] = "THREE!!!!!");

            foreach (var item in mydictionary)
            {
                Console.WriteLine(item.Value);
            }


            Dictionary<string, Person> studentList = new Dictionary<string, Person>();

            studentList.Add("E00000000", new Person("Mathew", "Desjardins"));
            studentList.Add("E00000001", new Person("Mathew", "Desjardins"));
            studentList.Add("E00000002", new Person("Mathew", "Desjardins"));
            studentList.Add("E00000003", new Person("Mathew", "Desjardins"));
            studentList.Add("E00000004", new Person("Mathew", "Desjardins"));
            studentList.Add("E00000005", new Person("Mathew", "Desjardins"));
            studentList.Add("E00000006", new Person("Mathew", "Desjardins"));


            string output = Person.CSVHeader() + "\n";

            foreach (var item in studentList)
            {
                output += item.Value.ToDelimtedFileFormater() + "\n";
            }


            //streamwriter output

            Console.WriteLine(output);


        }
    }
}
