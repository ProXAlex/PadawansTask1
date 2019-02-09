using System;

namespace PadawansTask1
{
    public class Population
    {

        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {

            if(initialPopulation <= 0 || percent <= 0 || visitors <= 0 || currentPopulation <= 0)
                throw new ArgumentException("Value cannot be less or equal zero");


            int years = 0;
            int population = initialPopulation;
            while (population <= currentPopulation)
            {
                population += (int)Math.Floor(population * percent / 100);
                population += visitors;
                years++;

            }

            return years;

            
        }

       
    }
}