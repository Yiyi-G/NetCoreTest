using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class UserProjectRelationTag
    {
        public long Uid { get; set; }
        public string Tag { get; set; }
        public UserProjectRelationTagKinds Kind { get; set; }
        public AddressBookFriend AddressBookFriend { get; set; }
    }
    
    public enum UserProjectRelationTagKinds : byte
    {
        AddressBook = 1,
        Indirect = 2,
        Mutual=3,
        Docked=4,
        ClassMate = 5
    }

}
