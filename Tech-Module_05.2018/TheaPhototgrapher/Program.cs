using System;

namespace TheaPhototgrapher
{
    class Program
    {
        static void Main()
        {
            int picturesCount = int.Parse(Console.ReadLine());
            int fTForPicture = int.Parse(Console.ReadLine());
            int goodPictPerrcentage = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double totalUploadTime = uploadTime * Math.Ceiling(picturesCount * goodPictPerrcentage / 100.0);
            int totalFilterTime = picturesCount * fTForPicture;
            double totalSec = totalFilterTime + totalUploadTime;
            
            
           
            double minutes = 0;
            double hours = 0;
            double days = 0;
            while (totalSec >= 60)
            {
                if (totalSec >= 60)
                {
                    minutes += 1;
                    totalSec -= 60;
                }
                if (minutes >= 60)
                {
                    hours += 1;
                    minutes -= 60;
                }
                if (hours >= 24)
                {
                    days += 1;
                    hours -= 24;
                }
            }
            
            Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{totalSec:00}");



        }
    }
}
