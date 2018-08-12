using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number");
            }
            catch (Exception err)
            {
                //Console.WriteLine("there was an error!");
                throw;
            }
            finally
            {
                Console.WriteLine("Closing Program");
            }           
        }
    }
}
