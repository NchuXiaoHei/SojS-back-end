using System;
using System.Collections.Generic;
using System.Text;

namespace SojS.BackEnd.OjProblemAUser
{
    /// <summary>
    /// OJ题目讨论板块的回复
    /// </summary>
    class OjProblemDiscussionReply
    {
        //标识符
        private int id { get; set; }
        //对应的讨论id
        private int DiscussionId { get; set; }
        //用户标识,即回复者
        private string UserId { get; set; }
        //回复内容
        private string ReplyContent { get; set; }
        //回复时间
        private DateTime ReplyTime { get; set; }

    }
}
