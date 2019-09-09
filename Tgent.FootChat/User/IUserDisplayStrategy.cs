using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.Models;

namespace Tgnet.FootChat.User
{
    public interface IUserDisplayStrategy
    {
        UserDisplayKind GetUserDisplayKind();
        bool CheckIsSelfInfo(long uid);

        string GetUserName(long uid, string userName, bool isVerify);
        bool GetIsForceShowName(long uid);
        bool GetIsForceShowMobile(long uid);
    }

    
    public class MyDisplayStrategy : IUserDisplayStrategy
    {
        IServiceStateService _User;
        private readonly Dictionary<long, AddressBookFriend> _AddressFriends;
        public MyDisplayStrategy(IServiceStateService user, Dictionary<long, AddressBookFriend> addressFriends)
        {
            _User = user;
            _AddressFriends = addressFriends ?? new Dictionary<long, AddressBookFriend>();

        }
        public bool CheckIsSelfInfo(long uid)
        {
            return false;
        }

        public bool GetIsForceShowMobile(long uid)
        {
            return false;
        }

        public bool GetIsForceShowName(long uid)
        {
           return true;
        }

        public UserDisplayKind GetUserDisplayKind()
        {
            return UserDisplayKind.HideInfo;
        }

        public string GetUserName(long uid, string userName, bool isVerify)
        {
            if (_AddressFriends.ContainsKey(uid))
            {
                var addressFriend = _AddressFriends[uid];
                if (!_User.User.IsVerified && addressFriend != null && !string.IsNullOrWhiteSpace(addressFriend.Name))
                    return addressFriend.Name;
            }
            return _User.User.Name;
        }

        public bool GetIsForceHideMobile(long uid)
        {
            return true;
        }
    }
    public class UserDisplayStrategy : IUserDisplayStrategy
    {
        IServiceStateService _User;

        private readonly Dictionary<long, AddressBookFriend> _AddressFriends;
        public UserDisplayStrategy(IServiceStateService user, Dictionary<long, AddressBookFriend> addressFriends)
        {
            _User = user;
            _AddressFriends = addressFriends ?? new Dictionary<long, AddressBookFriend>();
        }
        public bool GetIsForceShowName(long uid)
        {
            if (_AddressFriends.ContainsKey(uid))
            {
                return true;
            }
            return false;
        }
        public bool GetIsForceShowMobile(long uid)
        {
            if (_AddressFriends.ContainsKey(uid))
            {
                return true;
            }
            return false;
        }

        public bool CheckIsSelfInfo(long uid)
        {
            return _User.Uid == uid;
        }
        public string GetUserName(long uid, string userName, bool isVerify)
        {
            if (_AddressFriends.ContainsKey(uid))
            {
                var addressFriend = _AddressFriends[uid];
                if (!isVerify && addressFriend != null && !string.IsNullOrWhiteSpace(addressFriend.Name))
                    return addressFriend.Name;
            }
            return userName;
        }

        public UserDisplayKind GetUserDisplayKind()
        {
            if (_User.User.VerifyStatus == VerifyStatus.Pass && _User.Expired > DateTime.Now)
                return UserDisplayKind.Visble;
            else
                return UserDisplayKind.OnlyHideOrtherInfo;
        }

    }

    public class UserPreviewStrategy : IUserDisplayStrategy
    {
        public UserPreviewStrategy()
        {
        }


        public bool CheckIsSelfInfo(long uid)
        {
            return false;
        }

        public bool GetIsForceShowMobile(long uid)
        {
            return false;
        }

        public bool GetIsForceShowName(long uid)
        {
            return false;
        }

        public UserDisplayKind GetUserDisplayKind()
        {
            return UserDisplayKind.HideInfo;
        }

        public string GetUserName(long uid, string userName, bool isVerify)
        {
            return userName;
        }
    }

}
