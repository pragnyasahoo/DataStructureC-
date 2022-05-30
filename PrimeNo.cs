using System;

public class Primeno
{
	public void PrintPrimeNo( int n)
    {
        int i, j;
        bool flag=false ;
        for (  i =3; i < n; i++)  
        {
            for (  j = 2; j < i; j++)
            {
                if (i % j != 0  )
                {
                    flag = false;
                   
                }
                if (i % j == 0)
                {
                    flag = true;
                    break;
                }
                
            } 
            if(flag==false)
            {
                Console.WriteLine("not prime{0}", i);
            }
          
        }

    }
}
