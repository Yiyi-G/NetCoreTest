using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tgnet.Core.Api
{
    [DataContract]
    public struct ErrorCode : IEquatable<ErrorCode>
    {
        /// <summary>
        /// 代表成功
        /// </summary>
        public static readonly ErrorCode None;
        public static readonly ErrorCode 未登录;
        public static readonly ErrorCode 输入的数据格式错误;
        public static readonly ErrorCode 连接已失效;
        public static readonly ErrorCode 在对方黑名单中;
        public static readonly ErrorCode 服务器错误;
        public static readonly ErrorCode 非法的操作;
        public static readonly ErrorCode 未找到该用户;
        public static readonly ErrorCode 没有操作权限;
        public static readonly ErrorCode 没有找到对应条目;
        public static readonly ErrorCode 对应条目已存在;
        public static readonly ErrorCode 数量不足;

        public static readonly ErrorCode 帐号不存在;
        public static readonly ErrorCode 帐号或密码不正确;
        public static readonly ErrorCode 设备未通过短信验证;
        public static readonly ErrorCode 该手机号码已被注册;
        public static readonly ErrorCode 该手机号未注册;
        public static readonly ErrorCode 验证码已过期;
        public static readonly ErrorCode 无效验证码;
        public static readonly ErrorCode 帐号资料未完善;
        public static readonly ErrorCode 刷新令牌已失效;

        public static readonly ErrorCode 好友申请不存在;
        public static readonly ErrorCode 好友不存在;
        public static readonly ErrorCode 不是好友关系;
        public static readonly ErrorCode 超出好友上限;
        public static readonly ErrorCode 对方超出好友上限;

        public static readonly ErrorCode 已达人数上限;
        public static readonly ErrorCode 非成员;
        public static readonly ErrorCode 用户组不存在;

        public static readonly ErrorCode 没有足够的查看次数;
        public static readonly ErrorCode 超出购买地区;
        public static readonly ErrorCode 工程信息账号未激活;
        public static readonly ErrorCode 个人帐号已过期;
        public static readonly ErrorCode 个人查看次数不足;
        public static readonly ErrorCode 高级会员服务已到期;
        public static readonly ErrorCode 试用高级会员查看次数不足;

        public static readonly ErrorCode 消息不存在;
        public static readonly ErrorCode 活动不存在;
        public static readonly ErrorCode 未参加活动;

        private static Dictionary<string, ErrorCode> m_Stroe = new Dictionary<string, ErrorCode>();

        static ErrorCode()
        {
            None = new ErrorCode("0x00000000", "操作成功", true);
            未登录 = new ErrorCode("0x00000001", "未登录或登录已失效", true);
            输入的数据格式错误 = new ErrorCode("0x00000002", "输入的数据格式错误", true);
            连接已失效 = new ErrorCode("0x00000003", "连接已失效", true);
            在对方黑名单中 = new ErrorCode("0x00000004", "在对方黑名单中", true);
            服务器错误 = new ErrorCode("0x00000005", "服务器错误", true);
            非法的操作 = new ErrorCode("0x00000006", "非法的操作", true);
            未找到该用户 = new ErrorCode("0x00000007", "未找到该用户", true);
            没有操作权限 = new ErrorCode("0x00000008", "没有操作权限", true);
            没有找到对应条目 = new ErrorCode("0x00000009", "没有找到对应条目", true);
            对应条目已存在 = new ErrorCode("0x00000010", "对应条目已存在", true);
            数量不足 = new ErrorCode("0x00000011", "数量不足", true);

            帐号不存在 = new ErrorCode("0x00010001", "帐号不存在", true);
            帐号或密码不正确 = new ErrorCode("0x00010002", "帐号或密码不正确", true);
            设备未通过短信验证 = new ErrorCode("0x00010003", "设备未通过短信验证", true);
            该手机号码已被注册 = new ErrorCode("0x00010004", "该手机号码已被注册", true);
            该手机号未注册 = new ErrorCode("0x00010005", "该手机号未注册", true);
            验证码已过期 = new ErrorCode("0x00010006", "验证码已过期", true);
            无效验证码 = new ErrorCode("0x00010007", "无效验证码", true);
            帐号资料未完善 = new ErrorCode("0x00010008", "帐号资料未完善", true);
            刷新令牌已失效 = new ErrorCode("0x00010009", "刷新令牌已失效", true);

            好友申请不存在 = new ErrorCode("0x00020001", "好友申请不存在", true);
            好友不存在 = new ErrorCode("0x00020002", "好友不存在", true);
            不是好友关系 = new ErrorCode("0x00020003", "不是好友关系", true);
            超出好友上限 = new ErrorCode("0x00020004", "超出好友上限", true);
            对方超出好友上限 = new ErrorCode("0x00020005", "对方超出好友上限", true);

            已达人数上限 = new ErrorCode("0x00030001", "已达人数上限", true);
            非成员 = new ErrorCode("0x00030002", "非成员", true);
            用户组不存在 = new ErrorCode("0x00030003", "用户组不存在", true);

            没有足够的查看次数 = new ErrorCode("0x00040001", "没有足够的查看次数", true);
            超出购买地区 = new ErrorCode("0x00040002", "超出购买地区", true);
            工程信息账号未激活 = new ErrorCode("0x00040003", "工程信息账号未激活", true);
            个人帐号已过期 = new ErrorCode("0x00040004", "个人帐号已过期", true);
            个人查看次数不足 = new ErrorCode("0x00040005", "个人查看次数不足", true);
            高级会员服务已到期 = new ErrorCode("0x00040006", "高级会员服务已到期", true);
            试用高级会员查看次数不足 = new ErrorCode("0x00040007", "试用高级会员查看次数不足", true);
        }

        private string m_Code;
        private string m_Message;
        private bool m_IsStore;

        [DataMember]
        public string Code { get { return m_Code; } set { if (!m_IsStore) m_Code = value; } }
        [DataMember]
        public string Message { get { return m_Message; } set { if (!m_IsStore) m_Message = value; } }

        private ErrorCode(string code, string message, bool store)
        {
            m_Code = code.Trim();
            m_Message = message;
            m_IsStore = store;
            if(store)
                m_Stroe.Add(m_Code, this);
        }

        public ErrorCode(string code)
            : this(code, String.Empty, false) { }

        public ErrorCode(string code, string message)
            : this(code, message, false) { }

        public override string ToString()
        {
            return Code;
        }

        public bool Equals(ErrorCode other)
        {
            return other.Code == Code;
        }

        public static bool TryParse(string code, out ErrorCode error)
        {
            return m_Stroe.TryGetValue(code, out error);
        }
    }
}
