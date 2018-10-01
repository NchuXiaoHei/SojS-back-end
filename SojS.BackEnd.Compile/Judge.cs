using System;
using System.Diagnostics;
using System.Threading;

namespace SojS.BackEnd.Compile
{
    class Judge
    {
        //用户提交代码的答案存放路径
        private static string str1 = @"D:\SojS\SojSTest\UserOut\";
        //标准答案存放路径
        private static string str2 = @"D:\SojS\SojSTest\UserOut\";
        public string Compile(string[] args)
        {
            Process p = new Process();
            //调用cmd
            p.StartInfo.FileName = "cmd.exe";
            //关闭Shell的使用
            p.StartInfo.UseShellExecute = false;
            //重定向标准输入
            p.StartInfo.RedirectStandardInput = true;
            //重定向标准输出
            p.StartInfo.RedirectStandardOutput = true;
            //重定向错误输出
            p.StartInfo.RedirectStandardError = true;
            //设置不显示窗口
            p.StartInfo.CreateNoWindow = true;

            //语言
            string language = args[0];
            //待编译文件名
            string fileName = args[1];
            //题号
            string problemNumber = args[2];
            //获得编译命令
            string strPath = GetCompilerStrPath(language, fileName);

            //编译
            p.Start();
            p.StandardInput.WriteLine(strPath);
            Thread.Sleep(500);

            //获得运行命令
            strPath = GetRunStrPath(language, fileName, problemNumber);
            //运行
            p.StandardInput.WriteLine(strPath);

            //获取文件路径
            //对比答案和标准答案
            p.StandardInput.WriteLine(@"fc D:\SojS\SojSTest\UserOut\" + fileName + ".out " + @"D:\SojS\SojSTest\Out\" + problemNumber + ".out");

            p.StandardInput.WriteLine("exit");

            //得到结果
            string strResult = p.StandardOutput.ReadToEnd();

            //关闭进程
            p.Close();
            p.Dispose();

            //判断是否AC
            if(strResult.IndexOf("**") < 0)
            {
                return "AC";
            }
            else
            {
                return "WA";
            }

        }

        static string GetCompilerStrPath(string language, string fileName)
        {
            string strPath = "";
            //根据编程语言，设置编译命令
            if (language.Equals("c"))   
            {
                strPath = "g++ ";
                strPath += @"D:\SojS\SojSTest\C\" + fileName + ".cpp";
            }
            else if (language.Equals("java"))
            {
                strPath = "javac ";
                strPath += @"D:\SojS\SojSTest\Java\" + fileName + ".java";
            }
            
            return strPath;
        }

        static string GetRunStrPath(string language, string fileName, string problemNumber)
        {
            string strPath = "";
            //根据编程语言，设置执行命令
            if (language.Equals("c"))
            {
                //编译生成的exe文件的路径
                strPath += @"D:\SojS\SojSTest\C\" + fileName + ".exe ";
                //重定向输入到 D:\SojS\SojSTest\In\ ，即输入测试数据所在的文件夹，
                strPath += @"< D:\SojS\SojSTest\In\" + problemNumber + ".in ";
                //重定向输入到  D:\SojS\SojSTest\C\Out\ ， 即C语言文件夹下，用户程序的输出文件夹，作为题目答案，
                //之后与标准答案进行对比得出结果
                strPath += @"> D:\SojS\SojSTest\UserOut\" + fileName + ".out";
            }
            else if (language.Equals("java"))
            {
                strPath = "java ";
                //java执行路径
                strPath += @"D:\SojS\TestData\Java\" + fileName;
                //重定向输入到 D:\SojS\SojSTest\In\ ，即输入测试数据所在的文件夹，
                strPath += @"< D:\SojS\SojSTest\In\" + problemNumber + ".in ";
                //重定向输入到  D:\SojS\SojSTest\Java\Out\ ， 即C语言文件夹下，用户程序的输出文件夹，作为题目答案，
                //之后与标准答案进行对比得出结果
                strPath += @"> D:\SojS\SojSTest\UserOut\" + fileName + ".out";
            }

            return strPath;
        }
    }
}
