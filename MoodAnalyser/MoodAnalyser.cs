using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class AnalyzeMood
    {

       private string message;
        public AnalyzeMood(string message)
        {
            this.message = message;
        }

        public string getMood()
        {
            if (this.message.Contains("Sad"))
            {

                return "Sad";

            }
            else
            {


                return "Happy";
            }
        }

    }
}

