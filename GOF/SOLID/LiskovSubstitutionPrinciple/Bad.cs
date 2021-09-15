using GOF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
    public class Bad : IUsage
    {
        class Account
        {
            public virtual decimal GetInterest(decimal sum, int month, int rate)
            {
                if (sum < 0 || month > 12 || month < 1 || rate < 0)
                    throw new Exception("Incorrect data");

                decimal result = sum;
                for (int i = 0; i < month; i++)
                    result += result * rate / 100;

                if (sum >= 1000)
                    result += 100;

                return result;
            }
        }

        class MicroAccount : Account
        {
            public override decimal GetInterest(decimal sum, int month, int rate)
            {
                if (sum < 0 || month > 12 || month < 1 || rate < 0)
                    throw new Exception("Incorrect data ");

                decimal result = sum;
                for (int i = 0; i < month; i++)
                    result += result * rate / 100;

                return result;
            }
        }

        public void Usage()
        {
            void CalculateInterest(Account account)
            {
                decimal sum = account.GetInterest(1000, 1, 10); // 1000 + 1000 * 10 / 100 + 100 (bonus)
                if (sum != 1200) // expect 1200
                {
                    throw new Exception("Unexpected amount in calculations ");
                }
            }

            Account acc = new MicroAccount();
            CalculateInterest(acc); // get 1100 without bonus 100
        }
    }
}
