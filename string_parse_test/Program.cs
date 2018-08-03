using System;
using System.Collections.Generic;
using System.Linq;

namespace string_parse_test
{
    class Program
    {
        static void Main(string[] args)
        {

            var shortCode = "N2";
            var contractOptions = "B1:Yeni Kimlik|1,N2:Eski Pasaport|3";
            Dictionary<string, string> dic = new Dictionary<String, String>();
            if (contractOptions != null)
            {
                var contractOptionList = contractOptions.Split(',');
                foreach (var option in contractOptionList)
                {
                    var x = option.Split(':');
                    var optionShortCode = x[0];
                    var optionText = x[1];

                    dic.Add(optionShortCode, optionText);

                    Console.WriteLine("optionShortCode: " + optionShortCode);
                    Console.WriteLine("optionText: " + optionText);
                }
            }


            var a = (from keyValue in dic where (keyValue.Key == "N2") select keyValue.Value).FirstOrDefault();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
