#region evvel 7, axir 8 
//int Num = int.Parse(Console.ReadLine());
//if ((Num/1000 >= 1) && (Num/1000 <10))
//{
//    Console.WriteLine("7"+Num+"8");
//}
//else
//{
//    Console.WriteLine("4 reqemli eded deyil.");
//};
#endregion
#region ededin axirina ededin ozu
//int Num = int.Parse(Console.ReadLine());
//if ((Num / 100 >= 1) && (Num / 100 < 10))
//{
//    string result = Num.ToString();
//    Console.WriteLine(result + result);
//}
//else
//{
//    Console.WriteLine("3 reqemli eded deyil.");
//};
#endregion
#region 18%
//float Num = float.Parse(Console.ReadLine());
//if ((Num / 10000 >= 1) && (Num / 10000 < 10))
//{
//    float num2 =(Num / 100) * 18;
//    float num3 = (num2 / 100) * 3;
//    Console.WriteLine(num3);
//}
//else
//{
//    Console.WriteLine("5 reqemli eded deyil.");
//};
#endregion
#region 7-7
//int Num = int.Parse(Console.ReadLine());
//if ((Num / 100 >= 1) && (Num / 100 < 10))
//{
//    string result = Num.ToString();
//    result = result + "7";
//    Console.WriteLine(float.Parse(result) * 0.07);
//}
//else
//{
//    Console.WriteLine("3 reqemli eded deyil.");
//}
#endregion
#region 44%
//int Num = int.Parse(Console.ReadLine());
//if ((Num / 1000 >= 1) && (Num / 1000 < 10))
//{
//    string result = Num.ToString();
//    result = 4 + result + 44;
//    Console.WriteLine(float.Parse(result) * 0.44);
//}
//else
//{
//    Console.WriteLine("4 reqemli eded deyil.");
//}
#endregion
#region 20-10-kvadrat
//double Num = double.Parse(Console.ReadLine());
//if ((Num / 1000 >= 1) && (Num / 1000 < 10))
//{
//    Num = Num * 0.2;
//    Num = Num * 0.1;
//    Console.WriteLine(Num*=Num);
//}
//else
//{
//    Console.WriteLine("4 reqemli eded deyil.");
//};
#endregion
#region 2 5reqemli
int Num1 = int.Parse(Console.ReadLine());
int Num2 = int.Parse(Console.ReadLine());
if ((Num1/10000 >= 1) && (Num1/10000 <10) && (Num2 / 10000 >= 1) && (Num2 / 10000 < 10))
{
    int result = (Num1 + Num2);
    string result1 = result.ToString();
    result1 = 5 + result1 + 5;
    double result2 = double.Parse(result1);
    Console.WriteLine(result2*0.05);
}
else
{
    Console.WriteLine("ededlerden en azi biri 5 reqemli deyil.");
};
#endregion