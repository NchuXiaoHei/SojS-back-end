using System;
using System.Collections.Generic;
using System.Text;

namespace SojS.BackEnd.OjProblemAUser
{
    //用户提交
    class OjProblemUserCommit
    {
        //标识符
        private int Id { get; set; }
        //用户标识,做题的用户
        private string UserId { get; set; }
        //题目标识，所做的题
        private int ProblemId { get; set; }
        //代码类型标识，用户选择的系统支持的代码类型
        private int CodeTypeId { get; set; }
        //源代码
        private string SourceCode { get; set; }
        //代码大小，单位B
        private int SourceCodeSize { get; set; }
        //得分,本次提交的得分，综合所有测试点的结果进行计算
        private float CommitGrade { get; set; }
        //状态，提交的状态跟进更新，在判题完成之后应再次更新此状态（完全通过的或最严重错误的）
        //对于每一道题，同一个用户在上一提交未完成判题的状态下，不能发起新的提交
        private int CommitStatus { get; set; }
        //判题总耗时,单位ms
        private int JudgeTotalTime { get; set; }
        //最大占用内存，单位kb
        private int JudgeMaxMemory { get; set; }
        //提交时间
        private DateTime CommitTime { get; set; }
        //编译信息
        private string JudgeCompileMsg { get; set; }

    }
}
