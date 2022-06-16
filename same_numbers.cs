using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int nSize = int.Parse(Console.ReadLine()); // Enter n Dictionary size
            int mSize = int.Parse(Console.ReadLine()); // Enter m Dictionary size

            Dictionary<string, double> n = new Dictionary<string, double>(); // Define Dictionary n length
            Dictionary<string, double> m = new Dictionary<string, double>(); // Define Dictionary m length
            Dictionary<string, double> Dict_SameNumbers = new Dictionary<string, double>(); // Define Dictionary a with the same numbers from the two Dictionaries

            // Fill n array
            for (int i=0; i<nSize; i++)
            {
                string dic_key = "Element " + i; // Define Key Name
                double dic_value = double.Parse( Console.ReadLine() ); // Enter Value
                n.Add( dic_key, dic_value); // Add them to the Dictionary
            }

            // Fill m array
            for (int i = 0; i<mSize; i++)
            {
                // SAME for the other Dictionary
                string dic_key = "Element " + i;
                double dic_value = double.Parse(Console.ReadLine());
                m.Add(dic_key, dic_value);
            }

            if(n.Count > m.Count) // Bigger Dictionary is n
            {
                int currentElement = 0; // Counter for elements || When start its 0
                foreach(KeyValuePair<string, double> entryN in n) // Foreach in N Dictionary
                {
                    foreach(KeyValuePair<string, double> entryM in m) // Foreach in M Dictionary
                    {
                        if(entryN.Value == entryM.Value) // If the Current Values in the Dictionaries are EQUAL/SAME
                        {
                            currentElement++;// Increase Counter
                            Dict_SameNumbers.Add("Element " + currentElement, entryN.Value); // Add the current element to the Dictionary with same numbers
                        }
                    }
                }
            }
            else // Bigger Dictionary is m or they are EQUAL
            {
                // SAME mechanic
                int currentElement = 0;
                foreach (KeyValuePair<string, double> entryM in m)
                {
                    foreach (KeyValuePair<string, double> entryN in n)
                    {
                        if (entryN.Value == entryM.Value)
                        {
                            currentElement++;
                            Dict_SameNumbers.Add("Element " + currentElement, entryN.Value);
                        }
                    }
                }

            }

            // Dictionaries Prints
            Console.WriteLine("Dictionary n:" + String.Join(",", n));
            Console.WriteLine("Dictionary m:" + String.Join(",", m));
            Console.WriteLine("Dictionary a with same numbers: " + String.Join(",", Dict_SameNumbers));

            

        }
    }
}
