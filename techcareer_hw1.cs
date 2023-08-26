using System;

public class Homework
{
    void method1(int x) {
        if (x >=5) {
            Console.WriteLine("Integer greater that or equal to 5");
        }
        else {
            Console.WriteLine("integer smaller than 5");
        }
    }
    
    void method2(float x) {
        switch (x) {
            case 0.4f:
                Console.WriteLine("x = 0.4f");
                break;
            case 0.8f:
                Console.WriteLine("x = 0.8f");
                break;
            default:
                Console.WriteLine("x!=0.4f and x!=0.8f");
                break;
        }
    }
    
    void method3(string s) {
        int i = 0;
        while (i < s.Length) {
            Console.WriteLine(s[i]);
            i++;
        }
    }
    public static void Main(string[] args)
    {
        int i = 10;
        float f = 0.4f;
        string s = "Hello world";
        Homework hw = new Homework();
        hw.method1(i);
        hw.method2(f);
        hw.method3(s);
        
        
    }
}