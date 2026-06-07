class Homework
{
    static int MinMax(int[] integers, int option)
    {
        int number = integers[0];
        if (option == 0)
        {
            for (int i = 0; i < 10; i++)
            {
               if  (integers[i] < number) number = integers[i]; 
            }
            return number; 
        }

        if (option > 0)
        {
            for (int i = 0; i < 10; i++)
            {
                if (integers[i] > number) number = integers[i];
            }
            return number;
        }

        return 0;
    }

    static int Avg(int[] integers)
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
           sum += integers[i];
        }

        return sum / 10;
    }

    static int[] Reread()
    {
        int[] integers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            int data = Convert.ToInt32(Console.ReadLine());
            integers[i] = data;
        }

        return integers;
    }
    static void Main(String[] args)
    {
        int[] integers = new int[10]; 
        for (int i = 0; i < 10; i++)
        {
            int data = Convert.ToInt32(Console.ReadLine());
            integers[i] = data;
        }
        MinMax(integers, 1);
        Avg(integers);
        Reread();
    }
}
