using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantA4.Models
{
    public class TempStorage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>(); //new suggestion
        public static IEnumerable<Suggestion> Suggestions => suggestions; //set Suggestions

        public static void AddSuggestion(Suggestion suggestion)
        {
            suggestions.Add(suggestion); //add suggestion to list
        }
    }
}
