using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfTheDays = int.Parse(Console.ReadLine());
            var doctors = 7;
            var reviewedPatients = 0;
            var unReviewedPatients = 0;

            for (int i = 1; i <= numberOfTheDays; i++)
            {
                var dayPatients = int.Parse(Console.ReadLine());
                if (i%3 == 0 && unReviewedPatients > reviewedPatients)
                {
                    doctors++;
                }
                if (dayPatients > doctors)
                {
                    reviewedPatients += doctors;
                    unReviewedPatients += dayPatients - doctors;
                }
                else reviewedPatients += dayPatients;
            }
            Console.WriteLine($"Treated patients: {reviewedPatients}.");
            Console.WriteLine($"Untreated patients: {unReviewedPatients}.");
        }
    }
}
