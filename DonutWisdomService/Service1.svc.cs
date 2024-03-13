using System;
using System.Collections.Generic;

namespace DonutWisdomService
{
    /// <summary>
    /// Implements the DonutWisdomService contract, serving up delectable donut wisdom.
    /// </summary>
    public class Service1 : IService1
    {
        /// <summary>
        /// The repository of donut-related wisdom.
        /// (It WAS a private readonly List<string>, but we made it modifiable)
        /// </summary>
        private List<string> wisdom = new List<string>()
        {
            "The glaze is always brighter on the other donut.",
            "A balanced diet is a donut in each hand.",
            "Life is uncertain. Eat Dessert First.",
            "Spinkles make everything better.",
            "Always go for frosting, unless you see jelly-filled.",
            "A fresh plain donut beats a stale donut anyday."
        };

        /// <summary>
        /// Source of randomness for selecting donut wisdom.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// This lets new donut wisdom quotes get added to the list!
        /// </summary>
        /// <param name="newWisdom">The string param containing donut wisdom</param>
        public void AddWisdom(string newWisdom)
        {
            wisdom.Add(newWisdom);
        }

        /// <summary>
        /// Implements the GetWordsOfWisdom operation from the DonutWisdomService contract.
        /// Retrieves a random nugget of donut wisdom from the internal repository.
        /// </summary>
        /// <returns>A string containing a wise saying about donuts.</returns>
        public string GetWordsOfWisdom()
        {
            int index = random.Next(wisdom.Count); // Randomly select a quote
            return wisdom[index];                  // Return that wisdom
        }
    }
}
