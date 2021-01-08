class Program
{
    static void Main()
    {
        //Arithmetic operators
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b; //Output will be 13
        decimal d = a - b; //Output will be 7
        decimal e = a * b; //output will be 30
        decimal f = a / b; //output will be 3.33333
        decimal g = a % b; //output will be 1

        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);

        System.Console.WriteLine();

        //Assignment Operators
        a += 20M;
        System.Console.WriteLine(a); //Output will be 30
        a -= 20M;
        System.Console.WriteLine(a); //Output will be 10
        a *= 3M;
        System.Console.WriteLine(a); //Output will be 30
        a /= 3M;
        System.Console.WriteLine(a); //Output will be 10
        a %= 3M;
        System.Console.WriteLine(a); //Output will be 1

        System.Console.WriteLine();

        //Increament / Decreament operators
        a = 10M;
        System.Console.WriteLine(++a); //Output will be 11
        System.Console.WriteLine(a++); //Output will be 11
        System.Console.WriteLine(a); //Output will be 12
        System.Console.WriteLine(--a); //Output will be 11
        System.Console.WriteLine(a--); //Output will be 11
        System.Console.WriteLine(a);

        System.Console.WriteLine();

        //Comparision Operators
        bool b1 = a == 10;
        System.Console.WriteLine(b1); //Output will be true
        bool b2 = a != 10;
        System.Console.WriteLine(b2); //Output will be false
        bool b3 = a < 10;
        System.Console.WriteLine(b3); //Output will be false
        bool b4 = a > 10;
        System.Console.WriteLine(b4); //Output will be false
        bool b5 = a <= 10;
        System.Console.WriteLine(b5); //Output will be true
        bool b6 = a >= 10;
        System.Console.WriteLine(b6); //Output will be true

        System.Console.WriteLine();

        //Logical Operators
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7); //Output will be false
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b7); //Output will be false
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9); //Output will be true
        bool b10 = a == 10 || b == 10;
        System.Console.WriteLine(b10); //Output will be true
        bool b11 = !(a == 10);
        System.Console.WriteLine(b11); //Output will be false
        bool b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12); //Output will be false

        System.Console.WriteLine();

        //Concatenation Operator
        string name = "Pradeep";
        int age = 21;
        string message = "Hey, " + name + ", your age is " + age + ".";
        System.Console.WriteLine(message);

        System.Console.WriteLine();

        //Ternary Operator
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
        System.Console.WriteLine(title);

        System.Console.WriteLine();

        //Operator Precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z);

        System.Console.ReadKey();
    }
}