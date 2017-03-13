using System.Collections.Generic;
using WalletKata.Users;
using WalletKata.Exceptions;

namespace WalletKata.Wallets
{
    public class WalletService
    {
        public List<Wallet> GetWalletsByUser(User user)
        {
            List<Wallet> walletList = new List<Wallet>();
            User loggedUser = UserSession.GetInstance().GetLoggedUser();
    
            if (loggedUser != null)
            {
                foreach (User friend in user.GetFriends())
                {
                    if (friend.Equals(loggedUser))
                    {
                        walletList = WalletDAO.FindWalletsByUser(user);
                    }
                }
              
                return walletList;
            }
            else
            {
                throw new UserNotLoggedInException();
            }      
        }         
    }
}