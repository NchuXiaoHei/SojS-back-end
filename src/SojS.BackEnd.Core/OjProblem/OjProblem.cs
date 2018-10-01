using System;
using System.Collections.Generic;
using System.Text;

namespace SojS.BackEnd.OjProblem
{
    /// <summary>
    /// OJ题目
    /// </summary>
    class OjProblem
    {
        //题目标识符
        private int Id { get; set; }
        //用户标识符，表明题目的上传者
        private string UserId { get; set; }
        //题目类型标识
        private int TypeId { get; set; }
        //评测方式标识，系统支持的测评方式：【文本比较，】
        private int JudgeModeId { get; set; }
        //io类型标识，系统支持的io类型：【标准输入输出，】
        private int IOTypeId { get; set; }
        //题目标题
        private string Title { get; set; }
        //题目描述
        private string Description { get; set; }
        //输入格式
        private string InputDesc { get; set; }
        //输出格式
        private string OutputDesc { get; set; }
        //样例解释，对题目样例的一个简单说明，当需要对多个示例进行说明时，在此追加
        private string ExampleExplain { get; set; }
        //数据范围提示
        private string DataRangeHint { get; set; }
        //内存限制，单位kb
        private string MemoryLimit { get; set; }
        //时间限制，单位ms
        private int TimeLimit { get; set; }
        //上传者是否匿名，设置为true时，界面将在上传者处显示“匿名”
        private bool IsNameless { get; set; }
        //提交次数
        private int CommitNum { get; set; }
        //AC次数
        private int AcceptNum { get; set; }
        //上传时间
        private DateTime PubTime { get; set; }
        //题目状态
        private int Status { get; set; }
        //测试点数量,测试点数量决定了测试用例的数量
        private int TestCaseNum { get; set; }

        
    }
}
