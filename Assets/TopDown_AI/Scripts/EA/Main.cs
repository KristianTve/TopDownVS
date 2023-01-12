using static Tensorflow.Binding;
using static Tensorflow.KerasApi;
using Tensorflow;
using NumSharp;
using System;

namespace TopDown_AI.Scripts
{
    // https://www.researchgate.net/figure/Pseudocode-of-the-standard-genetic-algorithm-GA_fig2_3418804
    public class Main
    {
        void GA(string s)
        {
            // Set generation to 0
            //Initialize population to random individuals from S*
            // Evaluate fitness of old individuals

            // While termination condition is not met:
            while (true)
            {
                System.console;   
                // Select fittest individuals from Pt

                // Recombine individuals

                // Mutate individuals

                // EVALUATE FITNESS

                // Set next population as newly created individuals

                // Increment generation count
            } 
        }

        void fitnessEvaluator()
        {
            
        }
    }
}