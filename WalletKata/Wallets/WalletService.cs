using System.Collections.Generic;
using WalletKata.Users;
using WalletKata.Exceptions;

namespace WalletKata.Wallets
{
    public class WalletService
    {
		private IWalletDAO walletDao;
		private UserSession userSessionInstance = UserSession.GetInstance();

        public List<Wallet> GetWalletsFromFriend(User user)
        {
            List<Wallet> walletList = new List<Wallet>();
            User loggedUser = userSessionInstance.GetLoggedUser();
    
            if (loggedUser != null && user != null)
            {
				if(loggedUser.HasFriend(user))
				{
					walletList = walletDao.FindWalletsByUser(user);
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