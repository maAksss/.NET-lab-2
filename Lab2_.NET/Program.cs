using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {   Console.OutputEncoding = System.Text.Encoding.UTF8;

        Assembly asm = Assembly.LoadFrom("MyMathDll.dll");

        object obj = asm.CreateInstance("vscode");
        Type type = asm.GetType("vscode");

        // ---
        Console.Write("Введіть число для факторіалу: ");
        int n = int.Parse(Console.ReadLine());

        MethodInfo factorialMethod = type.GetMethod("Factorial");

        object[] factParams = new object[] { n };

        Console.WriteLine("Факторіал = " +
            factorialMethod.Invoke(obj, factParams));

        // ---
        Console.WriteLine("\nВведіть сторони трикутника:");

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        MethodInfo areaMethod = type.GetMethod("TriangleArea");

        object[] areaParams = new object[] { a, b, c };

        double area = (double)areaMethod.Invoke(obj, areaParams);

        if (area == -1)
            Console.WriteLine("Трикутник не існує!");
        else
            Console.WriteLine("Площа трикутника = " + area);

        Console.ReadLine();
    }
}
