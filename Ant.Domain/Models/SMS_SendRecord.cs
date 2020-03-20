using Ant.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Models
{
    public  class SMS_SendRecord : Entity
    {
        /// <summary>
        /// Desc:邮件内容
        /// Default:
        /// Nullable:True
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Desc:是否发送成功
        /// Default:0
        /// Nullable:False
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// Desc:发送时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Desc:标题
        /// Default:
        /// Nullable:True
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Desc:IP
        /// Default:
        /// Nullable:False
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// Desc:接收方（邮箱/手机号码）
        /// Default:
        /// Nullable:False
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// Desc:备注
        /// Default:
        /// Nullable:False
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Desc:邮件发送使用到的模板类型ID
        /// Default:0
        /// Nullable:True
        /// </summary>
        public int? SMSTemplateID { get; set; }

        /// <summary>
        /// Desc:记录类型(1:短信;2:邮件)
        /// Default:2
        /// Nullable:False
        /// </summary>
        public byte SMSType { get; set; }
    }
}
