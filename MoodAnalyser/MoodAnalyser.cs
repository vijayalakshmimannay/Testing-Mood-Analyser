﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class AnalyzeMood
    {

        public string getMood(string mood)
        {
            if (mood.Contains("Sad"))
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

