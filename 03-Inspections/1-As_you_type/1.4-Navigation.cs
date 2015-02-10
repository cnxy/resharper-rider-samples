﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Navigate between highlights
    //
    // Alt+PageUp and Alt+PageDn (VS)
    // F12 and Shift+F12 (IntelliJ)
    //
    // Navigate between errors
    //
    // Shift+Alt+PageUp and ShiftAlt+PageDown (VS)
    // Alt+F12 and Shift+Alt+F12 (IntelliJ)

    public class Navigation
    {
        public string ErrorHighlight()
        {
            // 1. Replace null with 3000 to make an error highlight
            return 3000;
        }

        public void WarningHighlight()
        {
            const int condition = 42;
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 2. Hints are not navigable
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            // 5. Highlights code that is redundant or unreachable
            //    Shows as greyed out
            //    Hover mouse over to see tooltip: "Method invocation is skipped..."
            ConditionalMethod();

            return;

            // "Code is unreachable"
            Console.WriteLine("Hello");
        }

        [Conditional("UndefinedSymbol")]
        private void ConditionalMethod()
        {
        }
    }
}