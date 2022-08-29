using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_Poli.Entities {
    public class Account {
        public double LoanLimit { get; set; }

        public int Number { get; private set; }
        public string Holder { get; private set; }

        public double Balance { get; protected set; }


        public Account() {

        }

        public Account(int number, string holder, double balance, double loanLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            LoanLimit = loanLimit;

        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) {
            Balance -= amount + 5;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

    }
}
