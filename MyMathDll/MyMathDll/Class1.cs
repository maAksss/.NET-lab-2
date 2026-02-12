using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class vscode
{
    public long Factorial(int n)
    {
        if (n < 0)
            return -1;

        long result = 1;

        for (int i = 1; i <= n; i++)
            result *= i;

        return result;
    }

    public double TriangleArea(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
            return -1;

        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
