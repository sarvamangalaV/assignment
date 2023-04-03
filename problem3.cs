using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<string> names = new List<string>() { "RAJ", "raj", "Avi", "Kirti" };
        Dictionary<string, int> nameCount = new Dictionary<string, int>();
        foreach (string name in names) {
            string lowercaseName = name.ToLower();
            if (nameCount.ContainsKey(lowercaseName)) {
                nameCount[lowercaseName]++;
            } else {
                nameCount[lowercaseName] = 1;
            }
        }
        foreach (KeyValuePair<string, int> entry in nameCount) {
            Console.WriteLine("{0} - {1}", entry.Key, entry.Value);
        }
    }
}