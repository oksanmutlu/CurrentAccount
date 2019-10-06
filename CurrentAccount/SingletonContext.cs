using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrentAccount;

namespace CurrentAccount
{
    public class Singleton
    {
        private static CurrentAccountContext context;
        public static CurrentAccountContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new CurrentAccountContext();
                }
                return context;
            }
        }
    }
}