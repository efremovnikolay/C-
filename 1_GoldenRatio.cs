using System;

class HelloWorld {
  static void Main() {
    //Функция: y = (x+1)^3 + 5*x^2
    //Интервал: от -2 до 2
      
    double FI = (1 + Math.Sqrt(5)) / 2; //1.6180339887
    
    double
        a=2,
        b=-2,
        eps=0.001,
        x1, x2, fx1, fx2;
    
    
    Console.WriteLine("Точка max:");
    while(Math.Abs(b - a) > eps){
        x1 = b-(b-a)/FI;
        x2 = a+(b-a)/FI;
        fx1 = Math.Pow((x1 + 1), 3) + 5*Math.Pow(x1, 2);
        fx2 = Math.Pow((x2 + 1), 3) + 5*Math.Pow(x2, 2);
        
        if(fx1>fx2)
            a=x1;
        else
            b=x2;
    }
    
    double x = (a + b) / 2;
    double resultX = Math.Pow((x + 1), 3) + 5*Math.Pow(x, 2);
    Console.WriteLine("x = " + x + " ; f(x) = " + resultX);
    
    a=2;
    b=-2;
    
    while(Math.Abs(b - a) > eps){
        x1 = b-(b-a)/FI;
        x2 = a+(b-a)/FI;
        fx1 = Math.Pow((x1 + 1), 3) + 5*Math.Pow(x1, 2);
        fx2 = Math.Pow((x2 + 1), 3) + 5*Math.Pow(x2, 2);
        
        if(fx1<fx2)
            a=x1;
        else
            b=x2;
    }
    
    Console.WriteLine("Точка min:");
    x = (a + b) / 2;
    resultX = Math.Pow((x + 1), 3) + 5*Math.Pow(x, 2);
    Console.WriteLine("x = " + x + " ; f(x) = " + resultX);
  }
}
