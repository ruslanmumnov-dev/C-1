// // Task1
// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// int maxx = int.MinValue;
// int minn = int.MaxValue;
// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0 ; i< n ; i++)
// {
//     if (maxx < arr[i])
//     {
//         maxx=arr[i];
//     }
//     if(minn > arr[i])
//     {
//         minn=arr[i];
    
//     }
// }
// Console.WriteLine("Max: "+maxx);
// Console.WriteLine("Minn: "+minn);




//task2

// int a = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// double sum=1;
// for( int i=1; i<=n; i++)
// {
//     sum+=Math.Pow(a,i);
// }
// Console.WriteLine("Sum:"+sum);


// //  task3
//  int n = Convert.ToInt32(Console.ReadLine());
//  int [] arr = new int[n];
//  int sum=0;
//  for (int i=0; i<n; i++)
//  {
//      arr[i] = Convert.ToInt32(Console.ReadLine());
//  }
//  for (int i=0; i<n; i++)
//  {
//      sum+=arr[i];
//  Console.WriteLine("Sum:"+sum+" " + arr[i]);
//  }

//task 4

// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int  [n];
// for (int i = 0; i<n; i++)
// {
//     arr[i]= Convert.ToInt32(Console.ReadLine());
// }
// int s=0;
// for(int i=0; i<n-1; i++)
// {
//     if( arr[i]>0 && arr[i+1]>0 || arr[i]<0 && arr[i+1]<0)
//     {
//         s=1;
        
//     }
// }
// if(s==0)
// {
//     Console.WriteLine("NO");
// }
// else
// {
//     Console.WriteLine("YES");
// }

//task 5

// int n =Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// for (int i=0; i<n; i++)
// {
//     arr [i] = Convert.ToInt32(Console.ReadLine());
// }
// Array.Sort(arr);
// for (int i=0; i<n-1; i++)
// {
//     if (arr[i]==arr[i+1])
//     Console.Write(arr[i]+" "+arr[i+1]+" ");
// }

// task 6

// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// for(int i=0; i<n; i++)
// {
//     arr[i]= Convert.ToInt32(Console.ReadLine());
// }
// Array.Sort(arr);
// Console.WriteLine(arr[0]);

//task 7

// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// int sum=0, col=0;
// for(int i=0; i<n; i++)
// {
//     Console.WriteLine("Giv a number:");     
//     arr [i] = Convert.ToInt32(Console.ReadLine());
   
// }
// for (int i=0; i<n; i++)
// {
//     if(arr[i] != 0)
//     {
//          col++;
//     }
//     sum+=arr[i];
// }
// Console.WriteLine("Sum of numbers:"+sum);
// Console.WriteLine("Count of numbers:"+col);

//task 8

// int  n =Convert.ToInt32(Console.ReadLine());
// int a1 = n/100;
// int a2 = n/10%10;
// int a3 = n%10;
// int sum, prod;
// sum = a1+a2+a3;
// prod = a1*a2*a3;
// Console.WriteLine($"{a1}+{a2}+{a3}={sum}");
// Console.WriteLine($"{a1}*{a2}*{a3}={prod}");

//task 9
//  int  n =Convert.ToInt32(Console.ReadLine());
//  int a;
//  for(int i=1; i<=10000; i*=10)
// {
//     a = n/i%10;
//   Console.Write(a);
// }

//task 10

// int n =Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// for (int i=0; i<n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i=0; i<n; i++)
// {
//     int cnt=0;
//     for (int j=1; j<=arr[i]; j++)
//     {
//         if( arr[i]%j == 0)
//         {
//             cnt++;
//         }
//     }
//     if (cnt>2)
//     {
//         Console.WriteLine(arr[i]+" ");
//     }
// }


