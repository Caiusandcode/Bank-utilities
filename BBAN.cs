using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_bban
{
    class BBAN
    {

        public string Account { get; set; }
        public bool IsMachineNumber { get; set; }
        public string MachineNumber { get; set; }


        public BBAN(string bban)
        {
            Account = bban;
            string tmpRefAccount = Account;
            IsMachineNumber = Checkprogram.CorrectNumber(ref tmpRefAccount);
            MachineNumber = tmpRefAccount;
        }

        public bool IsValid()
        {
            return Checkprogram.IsValidAccount(Account);
        }

        public override string ToString()
        {
            return $"BBAN: {Account}\n" +
                   $"MachineNumber: {MachineNumber}\n" +
                   $"IsValid: {IsMachineNumber}\n" +
                   $"--------------------------\n";
        }
    }
}
