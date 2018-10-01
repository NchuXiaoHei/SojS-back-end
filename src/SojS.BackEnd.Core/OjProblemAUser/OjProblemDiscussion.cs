using System;
using System.Collections.Generic;
using System.Text;

namespace SojS.BackEnd.OjProblemAUser
{
    /// <summary>
    /// OJ题目对应的讨论板块
    /// </summary>
    class OjProblemDiscussion
    {
        //标识符
        private int id { get; set; }
        //题目标识
        private int ProblemId { get; set; }
        //用户标识，发起讨论者
        private string UserId { get; set; }
        //讨论标题
        private string Title { get; set; }
        //发起时间
        private DateTime PubTime { get; set; }
        //编辑时间
        private DateTime EditTime { get; set; }
        //讨论内容
        private string Content { get; set; }
        
    }
}
