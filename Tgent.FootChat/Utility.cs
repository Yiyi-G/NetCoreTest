using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tgnet.Core;

namespace Tgnet.FootChat
{
    public static class Utility
    {
        private const string SplictChar = @",:.;/\-_，：。；、-—";
        public static string[] SplitTo( this string s)
        {
            var result = new string[0];
            if (string.IsNullOrWhiteSpace(s))
                return result;
            result = s.Split(SplictChar.ToCharArray()).Select(p => p.Trim()).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
            return result;
        }
        public static string GetHiddenTel(string strContent)
        {
            if (!String.IsNullOrEmpty(strContent))
                return Regex.Replace(strContent, @"(\d{3,4}[-/ \(\)]?){0,}(\d{3,})\d{4}", "$1********");
            else
                return String.Empty;
        }

        public static string ConvertCost(int cost)
        {
            if (cost == 0)
            {
                return "--";
            }
            if (cost >= 10000)
            {
                return Math.Round((double)cost / 10000, 2).ToString() + "亿";
            }
            else
            {
                return cost.ToString() + "万";
            }
        }

        public static string ConvertBuildSize(int size)
        {
            if (size == 0)
            {
                return "--";
            }
            else
            {
                return size.ToString() + "㎡";
            }
        }

        public static string HideUserName(string name, Tgnet.FootChat.User.UserSex? sex)
        {
            var firstName = "";
            var hidePart = "";
            if (string.IsNullOrWhiteSpace(name))
                return "";
            if (name.Length > 3)
                firstName = name.Left(2);
            else
                firstName = name.Left(1);
            switch (sex)
            {
                case Tgnet.FootChat.User.UserSex.Man:
                    hidePart = "先生";
                    break;
                case Tgnet.FootChat.User.UserSex.Woman:
                    hidePart = "女士";
                    break;
                default:
                    hidePart = "**";
                    break;
            }
            return firstName + hidePart;
        }

    }
}

