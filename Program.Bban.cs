using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_bban
{
    class Program
    {
        static void Main(string[] args)
        {
            BBAN BBANnew = new BBAN("227720A35988");
            string machineFormat = BBANnew;
            BBANnew.IsMachineNumber = Checkprogram.CorrectNumber(ref machineFormat);
            BBANnew = machineFormat;
            Console.WriteLine(BBANnew.ToString());
       
            BBAN account_2 = new BBAN("123456-781");
            Console.WriteLine(account_2.ToString());


            Console.WriteLine($"{BBANnew} - {BBANnew.IsValid()}");

            string machineformat = "A227720-35988";
            bool isMachineFormat = Checkprogram.CorrectNumber(ref machineFormat);
            if (isMachineFormat)
                Console.WriteLine($"{machineFormat} - {Checkprogram.IsValidAccount(machineFormat)}");
            else
                Console.WriteLine("Account number incorrect!");
        }
    }
}
