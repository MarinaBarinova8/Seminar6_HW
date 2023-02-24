//Задача 43. Напишите программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y =k2 * x + b2,
// значения k1, k2, b1, b2 задаются пользователем
//b1 =2, k1 = 5, b2 = 4, k2 = 9  ->(-0,5;-0,5)

/*y = k1 * x + b1;
y =k2 * x + b2;
k1 * x + b1 = k2 * x + b2;
k1 * x - k2 * x = b2- b1;
x(k1-k2) =b2- b1;
x = (b2- b1)/ (k1-k2);
x = (4-2)/(5-9) =2/(-4)=-0.5;
y = 5*(-0.5)+2=-2.5+5=-0.5;
*/

void IntersectionPoint (int b1, int k1, int b2, int k2)
{
    
   

    int dif_k = k1 - k2;
    
    float x = (float)(b2 - b1) / (float)(k1 - k2);
    float y = k1 * x + b1;
    
    
    if (dif_k != 0)
    {
        Console.WriteLine($"The point of intersection of lines is ({x};{y})");
    }
        
    else
    {
        Console.WriteLine("There is no intersection point!");
    }
}


Console.Write("Input  number b1:  ");
int b1_user = Convert.ToInt32(Console.ReadLine());

Console.Write("Input  number k1:  ");
int k1_user = Convert.ToInt32(Console.ReadLine());

Console.Write("Input  number b2:  ");
int b2_user = Convert.ToInt32(Console.ReadLine());

Console.Write("Input  number k2:  ");
int k2_user = Convert.ToInt32(Console.ReadLine());


IntersectionPoint (b1_user, k1_user, b2_user, k2_user);