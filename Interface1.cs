using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_for_lesson_1
{
    interface ISelling
    {
        public void Sell(string reason, double price);
        public void Buy(string puprose, double price);
    }
}
