static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] =new int[]{ 3,2,1};
            a[1] =new int[]{ 0,0,0};
            a[2] =new int[]{ 0,0,0};

            DisplayHanoi();
            Hanoi(3, 0, 1);
            
            void MovePiece(int x, int y)
            {
                bool breaked = false;
                for(int i = 2; i >= 0; i--)
                {
                    if (a[x][i] != 0)
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            if (a[y][j] == 0)
                            {
                                Console.WriteLine("{0}->{1}", x, y);
                                a[y][j] = a[x][i];
                                a[x][i] = 0;
                                breaked = true;
                                break;
                            }
                        }                        
                    }
                    if (breaked)
                    {
                        break;
                    }
                }
            }
            void DisplayHanoi()
            {
                for(int i = 2; i>=0 ; i--)
                {
                    for(int j = 0; j <3; j++)
                    {
                        Console.Write(a[j][i] + " ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine();
            }
            void Hanoi(int x, int i,int j)
            {
                if (x > 1)
                {
                    Hanoi(x - 1, i, 3 - i - j);
                    MovePiece(i, j);
                    //Console.WriteLine("{0}->{1}", i, j);
                    DisplayHanoi();
                    Hanoi(x - 1, 3 - i - j, j);
                }
                else
                {
                    MovePiece(i,j);
                    //Console.WriteLine("{0}->{1}", i, j);
                    DisplayHanoi();
                }
            }
        }
