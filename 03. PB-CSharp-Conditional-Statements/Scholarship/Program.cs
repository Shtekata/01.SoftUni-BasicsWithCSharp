using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double earnings = double.Parse(Console.ReadLine());
            double averageSuccsess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double scholarshipForSuccsess = 0;

            if (earnings < minimalSalary && averageSuccsess > 4.5)
            {
                socialScholarship = Math.Floor(0.35 * minimalSalary);
            }
            if (averageSuccsess >= 5.5)
            {
                scholarshipForSuccsess = Math.Floor(averageSuccsess * 25);
            }
            if (socialScholarship == 0 && scholarshipForSuccsess == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship>scholarshipForSuccsess)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (scholarshipForSuccsess >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for exellent results {scholarshipForSuccsess} BGN");
            }
        }
    }
}
