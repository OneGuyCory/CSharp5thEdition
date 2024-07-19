Console.WriteLine("What is the triangles base size?");
double baseSize = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the triangles height?");
double height = Convert.ToDouble(Console.ReadLine());

double area = (baseSize * height) / 2;

Console.WriteLine("Area of your triangle is " +  area);