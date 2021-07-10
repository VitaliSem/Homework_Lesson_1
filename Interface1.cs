using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_for_lesson_1
{
    interface ISelling
    {
        public string Sell(string reason, double price);
        public string Buy(string puprose, double price);
    }
}
