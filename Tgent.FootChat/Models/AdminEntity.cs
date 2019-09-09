using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class AdminEntity
    {
        private string _EncryptPassword;
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string UserNo { get; set; }
        public string ACLModules { get; set; }
        public string ACLChackCode { get; set; }

        public bool Lock { get; set; }

        public bool CheckPassword(string userPwd)
        {
            if (String.IsNullOrWhiteSpace(this.UserNo) || String.IsNullOrWhiteSpace(userPwd))
            {
                return false;
            }

            return GetSafePwd(this.UserNo, userPwd) == _EncryptPassword;
        }

        public void SetEncryptPassword(string encryptPassword)
        {
            _EncryptPassword = encryptPassword;
        }

        #region
        private static byte[] sKey = { 15, 187, 62, 95, 155, 214, 99, 37 };
        private static byte[] sIV = { 32, 19, 91, 175, 245, 49, 6, 73 };

        private string GetSafePwd(string userNo, string userPwd)
        {
            return EncryptString(userNo.ToLower() + "/" + userPwd,
                sKey, sIV);
        }

        private static string EncryptString(byte[] byteArray, byte[] sKey, byte[] sIV)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            des.Key = sKey;
            des.IV = sIV;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(byteArray, 0, byteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }

        public static string EncryptString(string strToEncrypt, byte[] sKey, byte[] sIV)
        {
            byte[] inputByteArray = Encoding.Default.GetBytes(strToEncrypt);
            return EncryptString(inputByteArray, sKey, sIV);
        }
        #endregion
    }
}
