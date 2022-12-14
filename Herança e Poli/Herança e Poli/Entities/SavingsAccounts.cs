using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_Poli.Entities {
    public  class SavingAccounts : Account {
        public double InterestRate { get; set; }
        public SavingAccounts() {
        }

        public SavingAccounts(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpddateBalance() {
            Balance += Balance * InterestRate;
        }
        public sealed override void Withdraw(double amount) {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
