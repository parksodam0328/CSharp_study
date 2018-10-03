using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input File Name : ");
            String fileNmae = Console.ReadLine();

            Console.WriteLine("Load : {0}", fileNmae);

            FileStream tmpFS = new FileStream(fileNmae, FileMode.OpenOrCreate);

            StreamWriter tmpSW = new StreamWriter(tmpFS);

            tmpSW.Write((long)65);
            tmpSW.WriteLine("ABCDEF");
            tmpSW.WriteLine("Text Writer");
            tmpSW.WriteLine("Hello C#");

            tmpSW.Close();
            tmpFS.Close();

            Console.Write("Load File Name : ");
            String loadName = Console.ReadLine();
            Console.WriteLine("Load : {0}", loadName);

            StreamReader tmpSR = new StreamReader(new FileStream(loadName, FileMode.Open));

            while (tmpSR.EndOfStream == false)
            {
                Console.WriteLine(tmpSR.ReadLine());
            }
            tmpSR.Close();
            /*FileStream tmpFS = new FileStream(fileNmae, FileMode.OpenOrCreate);

            BinaryWriter tmpBW = new BinaryWriter(tmpFS);

            tmpBW.Write((long)65);
            tmpBW.Write("ABCDEF");

            tmpBW.Close();

            tmpFS.Close();

            Console.Write("Load File Name : ");
            String loadName = Console.ReadLine();
            Console.WriteLine("Load : {0}", loadName);

            BinaryReader tmpBR = new BinaryReader(new FileStream(loadName, FileMode.Open));

            long numL = tmpBR.ReadInt64();
            string strL = tmpBR.ReadString();

            tmpBR.Close();

            Console.WriteLine("N : {0}", numL);

            Console.WriteLine("S : {0}", strL);
            */
            /*long tmpL = 65;

            String tmpSL = "ABCDEF";
            long strSize = Encoding.UTF8.GetByteCount(tmpSL);
            byte[] strBytes = Encoding.UTF8.GetBytes(tmpSL);
            byte[] sizeBytes = BitConverter.GetBytes(strSize);

            FileStream tmpFS = new FileStream(fileNmae, FileMode.OpenOrCreate);

            byte[] byteL = BitConverter.GetBytes(tmpL);

            tmpFS.Write(byteL, 0, sizeof(long));
            tmpFS.Write(sizeBytes, 0, sizeof(long));
            tmpFS.Write(strBytes, 0, (int)strSize);
            tmpFS.Close();
            */

            /*FileStream tmpFS = new FileStream(fileNmae, FileMode.Open);
            byte[] byteR = new byte[sizeof(long)];
            tmpFS.Read(byteR, 0, sizeof(long));

            long tmpR = BitConverter.ToInt64(byteR, 0);
            byte[] byteS = new byte[sizeof(long)];
            tmpFS.Read(byteS, 0, sizeof(long));

            long tmpSize = BitConverter.ToInt64(byteS, 0);
            byte[] byteStr = new byte[tmpSize];
            tmpFS.Read(byteStr, 0, (int)tmpSize);

            tmpFS.Close();

            Console.WriteLine("N:{0}", tmpR);

            String tmpStr = Encoding.UTF8.GetString(byteStr);
            Console.WriteLine("$:{0}", tmpStr);
            Console.ReadKey();*/

        }
    }
}
