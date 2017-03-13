using System.Collections.Generic;
using WalletKata.Users;

namespace WalletKata.Wallets
{
	public interface IWalletDAO{
		public List<Wallet> FindWalletsByUser(User user)
	}
}