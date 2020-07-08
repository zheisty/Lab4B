using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace Lab4B
{
    class Program
    {
        public static double CalculateBMI(double height, double weight)
        {
            double bmi = 0.0;
            //write code here to calculate the bmi of input data

            bmi = (weight * 705) / (height * height);


            return bmi;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating your BMI");
            Console.WriteLine("How many BMI's to be tested");
            int nbrUser = Convert.ToInt32(Console.ReadLine());

            // Input Weight
            // Input Height

          
            double weight = 0;
            double height = 0;
            int counter = 1;

            while (counter <= nbrUser)
            {

                Console.WriteLine("Enter Your Weight");
                weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Your Height");
                height = Convert.ToDouble(Console.ReadLine());

                double bmi =CalculateBMI(weight, height);

                Console.WriteLine("Your BMI is " + bmi);


                string[] result = { "Underweight", "Normal", "Overweight", "Obese" };

                
                if (bmi <= 18.5)
                    Console.WriteLine("You are " + result[0]);
                else if (bmi <= 25)
                    Console.WriteLine("You are " + result[1]);
                else if (bmi <= 30)
                    Console.WriteLine("You are " + result[2]);
                else
                    Console.WriteLine("You are " + result[3]);


                counter++;
            }
            
        }
    }
}