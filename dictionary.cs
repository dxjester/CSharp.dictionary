using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            phonebook.Add("Patrick", 8586993936);
            phonebook.Add("Chris", 8583370854);
            phonebook["Omid"] = 8582299791;

            Console.WriteLine(phonebook.Count);
            Console.ReadLine();
        }
    }
}
