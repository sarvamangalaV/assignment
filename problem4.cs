using System;
using System.Collections.Generic;

class AppMath {
    public static T Add<T>(params T[] args) {
        dynamic sum = default(T);
        foreach (T arg in args) {
            sum += arg;
        }
        return sum;
    }

    public static T Subtract<T>(params T[] args) {
        dynamic result = args[0];
        for (int i = 1; i < args.Length; i++) {
            result -= args[i];
        }
        return result;
    }

    public static T Multiply<T>(params T[] args) {
        dynamic product = 1;
        foreach (T arg in args) {
            product *= arg;
        }
        return product;
    }

    public static T Divide<T>(params T[] args) {
        dynamic result = args[0];
        for (int i = 1; i < args.Length; i++) {
            result /= args[i];
        }
        return result;
    }
}

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Adding: " + AppMath.Add(1, 2, 3, 4, 5)); // 15
        Console.WriteLine("Subtracting: " + AppMath.Subtract(10, 2, 3)); // 5
        Console.WriteLine("Multiplying: " + AppMath.Multiply(1.5, 2.0, 3.0)); // 9
        Console.WriteLine("Dividing: " + AppMath.Divide(100.0m, 2, 5)); // 10
    }
}