using System.Collections;
using System.Collections.Generic;

namespace WalletKata.Users
{
    public class User
    {
        private List<User> friends = new List<User>();

        public IEnumerable<User> GetFriends()
        {
            return friends;
        }

        public void AddFriend(User friend)
        {
            friends.Add(friend);
        }

		public bool HasFriend(User user)
		{
			 foreach (User friend in friends)
             {
				if (friend.Equals(user))
				{
					return true;
				}
			 }

			 return false;
		}
    }
}