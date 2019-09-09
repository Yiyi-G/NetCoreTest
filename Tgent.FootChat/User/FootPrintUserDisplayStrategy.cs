using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.Models;

namespace Tgnet.FootChat.User
{
    public interface IFootPrintUserDisplayStrategy
    {
        UserDisplayKind GetUserDisplayKind();
        bool CheckIsSelfInfo(long uid);

        string GetUserName(long uid, string userName, bool isVerify);
        bool GetIsForceShowName(long uid,long fid);
        bool GetIsForceShowMobile(long uid,long fid);
        bool GetIsForceHideMobile(long uid, long fid);
    }

    
    public class FootPrintUserDisplayStrategy : IFootPrintUserDisplayStrategy
    {
        IServiceStateService _User;

        private readonly Dictionary<long, AddressBookFriend> _AddressFriends;
        private readonly long[] _DockFids;
        public FootPrintUserDisplayStrategy(IServiceStateService user,  Dictionary<long, AddressBookFriend> addressFriends, long[] dockFids)
        {
            _User = user;
            _AddressFriends = addressFriends ?? new Dictionary<long, AddressBookFriend>();
            _DockFids = dockFids ?? new long[0];
        }
        public bool GetIsForceShowName(long uid,long fid)
        {
            if (_AddressFriends.ContainsKey(uid)|| _DockFids.Contains(fid))
            {
                return true;
            }
            return false;
        }
        public bool GetIsForceShowMobile(long uid,long fid)
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

        public bool GetIsForceHideMobile(long uid, long fid)
        {
            if (!_DockFids.Contains(fid))
            {
                return true;
            }
            return false;
        }
    }

    public class FootPrintUserPreviewStrategy : IFootPrintUserDisplayStrategy
    {
        public FootPrintUserPreviewStrategy()
        {
        }


        public bool CheckIsSelfInfo(long uid)
        {
            return false;
        }

        public bool GetIsForceHideMobile(long uid, long fid)
        {
            return true;
        }


        public bool GetIsForceShowMobile(long uid, long fid)
        {
            return false;
        }

        public bool GetIsForceShowName(long uid, long fid)
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
