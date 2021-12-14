using System;

namespace ConsoleApp3
{
	class Program
	{
	
		static void Main(string[] args)//QAQ
				{
			int Record;
			int[] intNumber = new int[] {1,2,100,3,100,5,100,45,2,66,54,100,324,768,9 };
			//int HowMany100=0;
			int Delete=0;//这个是为了计算我输入了几个Y（我不是很会搞布尔值计算）
			/*（这一段意义不大了）for(Record=0; Record<intNumber.Length;Record++)
            {
				if (intNumber[Record] == 100)
					HowMany100++;
            }// 计算有多少个100，将数组减去改长度 */
			
			for(Record=0;Record<intNumber.Length ;Record++ )
            {
				if (intNumber[Record] == 100)
				{
					Console.WriteLine("Do you want to delete the 100 (y/n)");
					string Comfirm = Console.ReadLine();
					if (Comfirm == "y" || Comfirm == "Y")//选择是否删除100
					{
						Delete++;//同济我输入了几个y或者Y
						for (int i = Record; i < intNumber.Length - 1; i++)
						{
							intNumber[i] = intNumber[i + 1];
							
						}// 删除数据
						Record--;//将计数减一，否则会出错
					}
				}
            }
			for(Record=0;Record<intNumber.Length-Delete ;Record++)
            {
				Console.Write("{0}\t", intNumber[Record]);
            }
			
				}
		}
	}
