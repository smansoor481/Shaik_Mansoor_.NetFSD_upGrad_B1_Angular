using EntiryMVC.Database;
using EntityFrameworkAssignment.Entity;

namespace EntityFrameworkAssignment.Repository
{
    public class AccountRepository
    {
        private readonly AccDBContext context;

        public AccountRepository()
        {
            context = new AccDBContext();
        }

        // ADD
        public void AddAccount(Account account)
        {
            context.Accounts.Add(account);
            context.SaveChanges();
        }

     
        public void UpdateAccount(Account account)
        {
            var existing = context.Accounts.Find(account.AccountId);

            if (existing != null)
            {
                existing.AccountType = account.AccountType;
                existing.Customer = account.Customer;
                existing.Balance = account.Balance;
                existing.Branch = account.Branch;
                existing.CreatedDate = account.CreatedDate;

                context.SaveChanges();
            }
        }

        
        public void DeleteAccount(int id)
        {
            var acc = context.Accounts.FirstOrDefault(x => x.AccountId == id);

            if (acc != null)
            {
                context.Accounts.Remove(acc);
                context.SaveChanges();
            }
        }

        public Account? GetAccount(int id)
        {
            return context.Accounts.Find(id);
        }

        
        public List<Account> GetAccounts()
        {
            return context.Accounts.ToList();
        }
    }
}