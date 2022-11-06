using System.Collections.Generic;

namespace AccountManagement
{
    public class DataStore
    {
        public List<Account> Accounts;

        public DataStore(List<Account> accounts)
        {
            Accounts = accounts;
        }
    }
}