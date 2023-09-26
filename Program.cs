namespace Goofy_3._0
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Hello");
            Console.WriteLine("write username");
           
            
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            bool again = true;

            List<string> infos = new List<string>();     

            while (again)
            {
                Console.WriteLine("type information");
                string Information1 = Console.ReadLine();

                infos.Add(Information1);

                Console.WriteLine("type information is: " + Information1);

                Console.WriteLine("Want to add another information? (yes/no)");
                string yesNo = Console.ReadLine();
                if (yesNo.ToLower() == "no" ||  yesNo.ToLower() == "n")
                { 
                    break;
                }
                
            }
            for (int i = 0; i < infos.Count; i++)
            {
                Console.WriteLine($"Type information{i + 1} is: {infos[i]}");
                
            }




        }
    }
}