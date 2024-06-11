using System;
using System.Threading;

class MainClass
{
    public static void Main(string[] args)
    {

         
        char ch;

        
        int n = 5;

        
        
        int[] yilanX = new int[5];
        int[] yilanY = new int[5];

        
        
        for (int i = 0; i < 5; i++)
        {
            yilanX[i] = 20;
            yilanY[i] = 20 + i;
        }

        
        Console.CursorVisible = false;
        
        for (int i = 0; i < n; i++)
        {
            
            Console.SetCursorPosition(yilanX[i], yilanY[i]);
            
            Console.Write("*");
        }

        
        for (int i = 8; i < 62; i++)
        {
            Console.SetCursorPosition(i, 7);
            Console.Write("_");
            Console.SetCursorPosition(i, 30);
            Console.Write("_");
        }
        
        for (int i = 8; i < 31; i++)
        {
            Console.SetCursorPosition(8, i);
            Console.Write("|"); 
                                
            Console.SetCursorPosition(62, i);
            Console.Write("|");
        }

        
        ch = Console.ReadKey(true).KeyChar;

        
        while (true)
        {

            
            for (int j = 9; j < 61; j++)
            {
                Console.SetCursorPosition(j, 30);
                Console.Write("_");
            }

            
            for (int x = 9; x < 62; x++)
            {
                for (int j = 8; j < 30; j++)
                {
                    Console.SetCursorPosition(x, j);
                    Console.Write(" ");
                }
            }

            
            if (Console.KeyAvailable)
            {
                
                ch = Console.ReadKey(true).KeyChar;
            }
            

            
            for (int i = n - 1; i >= 0; i--)
            {

                
                if (i == 0)
                {

                    
                    switch (ch)
                    {
                        case 'a':
                            yilanX[i] -= 2;
                            break;
                        case 'w':
                            yilanY[i] -= 1;
                            break;
                        case 's':
                            yilanY[i] += 1;
                            break;
                        case 'd':
                            yilanX[i] += 2;
                            break;
                        case 'q':
                            goto EXIT;
                    }

                    
                    for (int u = 1; u < n; u++)
                    {
                        if (yilanX[i] == yilanX[u] && yilanY[i] == yilanY[u])
                        {
                            goto EXIT;
                        }
                    }

                    
                    if (yilanX[i] == 8 || yilanY[i] == 7 || yilanX[i] == 62 || yilanY[i] == 31)
                    {
                        goto EXIT;
                    }
                }

                
                else
                {
                    yilanX[i] = yilanX[i - 1];
                    yilanY[i] = yilanY[i - 1];
                }
            }

            
            for (int g = 0; g < 5; g++)
            {
                Console.SetCursorPosition(yilanX[g], yilanY[g]);
                Console.Write("*");
            }

                
            Thread.Sleep(100);
        }
    
    EXIT:
        
        Console.SetCursorPosition(24, 17);
        Console.Write("Game Over");
        Console.SetCursorPosition(24, 18);
        Console.Write("Try again later");
        Console.CursorVisible = true;
    }
}