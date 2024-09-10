using System;

namespace FarmHelper.Model
{
    public class FarmCalculator
    {
        public double dropChance { get; set; } // Item dropchance % -> 0.01 - 100
        public int mobCount { get; set; } // Mobs killed in one run

        public FarmCalculator(double dropChance, int mobCount)
        {
            this.dropChance = dropChance;
            this.mobCount = mobCount;
        }

        public double CalculateProbability(int numberOfRuns)
        {
            double probability = 1 - Math.Pow(1 - (dropChance / 100), mobCount * numberOfRuns);
            return probability; // 0.00 - 1.00
        }

        public int CalculateRequiredRuns(double targetProbability)
        {
            double prob = 0;
            int runs = 0;
            while(prob < targetProbability)
            {
                runs++;
                prob = CalculateProbability(runs);
            }
            return runs;
        }

    }
}
