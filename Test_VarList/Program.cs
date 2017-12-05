using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_VarList
{
    class Program
    {
        private static void TestSendVarData()
        {
            VarList args = new VarList();
            bool test_boolean = true;
            string test_string = "hello world!";

            args.Append("first").Append(2).Append(test_boolean).Append(test_string);

            /*SubValue系列接口演示*/
            SubVarData(args);

            /*AtValue系列接口演示*/
            AtVarData(args);

            /*SetValue系列接口演示*/
            SetVarData(args);
        }

        private static void SetVarData(VarList args)
        {
            string first_para = "change_first_para";
            int second_para = 100;
            bool result = false;
            string third_para = "change_third_para";

            args.SetStringIndexOf(0,first_para);
            args.SetIntIndexOf(1,second_para);
            args.SetBoolIndexOf(2,result);
            args.SetStringIndexOf(3,third_para);

            Console.WriteLine("SetValue部分，first_para = {0}, second_para = {1}, result = {2}, third_para = {3}", first_para, second_para, result, third_para);
        }

        private static void AtVarData(VarList args)
        {
            string first_para = args.AtStringIndexOf();

            int second_para = args.AtIntIndexOf(1);

            bool result = args.AtBoolIndexOf(2);

            string third_para = args.AtStringIndexOf(3);

            Console.WriteLine("AtValue部分，first_para = {0}, second_para = {1}, result = {2}, third_para = {3}",first_para, second_para, result,third_para);
        }

        private static void SubVarData(VarList args)
        {
            string first_para = args.SubStringValue();

            int second_para = args.SubIntValue();

            bool result = args.SubBoolValue();

            string third_para = args.SubStringValue();
            Console.WriteLine("SubValue部分，first_para = {0}, second_para = {1}, result = {2}, third_para = {3}", first_para, second_para, result, third_para);
        }

        static void Main(string[] args)
        {
            TestSendVarData();
            Console.ReadKey();
        }
    }
}
