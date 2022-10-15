//Question 5 (A)

 static bool inside(int x, int y, int x1, int y1, int x2, int y2)
{
    if (x > x1 && x < x2 && y > y1 && y < y2)
    {
        return true;
    }
    else
        return false;
}

inside(1, 1, 0, 0, 2, 3);

//question 5 (B)

static void inside1(int x, int y, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
{
    if (x > x1 && x < x2 && y > y1 && y < y2)
    {
        if (x > x3 && x < x4 && y > y3 && y < y4)
        {
            Console.WriteLine("True");
        }
    }
    else
        Console.WriteLine("False");
}

inside1(1, 1, 0.3, 0.5, 1.1, 0.7, 0.5, 0.2, 1.1, 2);
