using System;
using System.Collections.Generic;
using System.Text;

namespace SojS.BackEnd.OjProblem
{
    /// <summary>
    /// 判题列表
    /// </summary>
    class OjProblemTestList
    {
        //用户提交标识
        private int UserCommitId { get; set; }
        //测试用例标识
        private int TestCaseId { get; set; }
        //用户输出
        private string UserOutput { get; set; }
        //测试点状态（通过，不通过）
        private int TestCaseStatus { get; set; }
        //测试点得分
        private float TestCaseGrade { get; set; }
        //判题耗时
        private int TestTime { get; set; }
        //占用内存
        private int TestMemory { get; set; }
        //判题信息,预留为记录判题核心的辅助信息
        private string JudgeMessage { get; set; }
        //判题优先级，为判题核心扩展其他服务 预留，不同等级的服务其优先级不一致，优先级相同的用户可按照时间评定
        private int JudgePri { get; set; }
        //创建时间，作为优先级定义的第二元素，同时应该保证该字段与 提交时间 一致

    }
}
