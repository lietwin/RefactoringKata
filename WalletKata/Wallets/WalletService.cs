using System.Collections.Generic;
using WalletKata.Users;
using WalletKata.Exceptions;

namespace WalletKata.Wallets
{
    public class WalletService
    {
		private WalletDAO walletDao;
		private UserSession userSessionInstance = UserSession.GetInstance();

        public List<Wallet> GetWalletsByUser(User user)
        {
            List<Wallet> walletList = new List<Wallet>();
            User loggedUser = userSessionInstance.GetLoggedUser();
    
            if (loggedUser != null)
            {
				if(loggedUser.hasFriend(user))
				{
					walletList = walletDao.FindWalletsByUser(user);
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