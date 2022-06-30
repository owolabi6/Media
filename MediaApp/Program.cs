using System;

namespace MediaApp
{
    class Program
    {
        static void Main(string[] args)
        {
                         //QUESTION 1
            Console.WriteLine("------QUESTION 1--------");
            
             int analyser = 0;
    
            Console.Write("Enter the first number: ");
            int numA = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numB = Int32.Parse(Console.ReadLine());
    
            for (int i = numA; i <= numB; i++)
            {
                 if (i % 5 == 0) analyser++;
            }
    
            Console.WriteLine("{0} numbers found.", analyser);

                             //QUESTION 2
            Console.WriteLine("---------QUESTION 2------");

            int next = 0;
            int prev = 0;
            for (int i = 0; i < 101; i++)
            {
                int sum = next + prev;
                prev = next;
                next = sum;
                Console.WriteLine(next); 
            }

                             //QUESTION 3

            Console.WriteLine("---------QUESTION 3--------");

          /*  Console.WriteLine("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter forth number: ");
            double forthNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter fifth number: ");
            double fifthNumber = double.Parse(Console.ReadLine());
            
            if ((firstNumber >= secondNumber) && (firstNumber >= thirdNumber) && (firstNumber >= forthNumber) && (firstNumber >= fifthNumber))
        {
            Console.WriteLine("The biggest number is: {0}", firstNumber);
            return;
        }
        if ((secondNumber >= firstNumber) && (secondNumber >= thirdNumber) && (secondNumber >= forthNumber) && (secondNumber >= fifthNumber))
        {
            Console.WriteLine("The biggest number is: {0}", secondNumber);
            return;
        }
        if ((thirdNumber >= firstNumber) && (thirdNumber >= secondNumber) && (thirdNumber >= forthNumber) && (thirdNumber >= fifthNumber))
        {
            Console.WriteLine("The biggest number is: {0}", thirdNumber);
            return;
        }
        if ((forthNumber >= firstNumber) && (forthNumber >= secondNumber) && (forthNumber >= thirdNumber) && (forthNumber >= fifthNumber))
        {
            Console.WriteLine("The biggest number is: {0}", forthNumber);
            return;
        }
        if ((fifthNumber >= firstNumber) && (fifthNumber >= secondNumber) && (fifthNumber >= thirdNumber) && (fifthNumber >= forthNumber))
        {
            Console.WriteLine("The biggest number is: {0}", fifthNumber);
            return;
        }   */

        //QUESTION 4
            Console.WriteLine("--------QUESTION 4-------");

            Console.Write("Input A (not 0): ");
            sbyte a = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input B: ");
            sbyte b = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input C: ");
            sbyte c = Convert.ToSByte(Console.ReadLine());

            sbyte d = (sbyte)(b * b - 4 * a * c);
            if (d < 0)
                Console.WriteLine("\nD={0}\nThere are no real roots.", d);
            else if (d == 0)
            {
                sbyte vp = (sbyte)(-b / 2 * a);
                Console.WriteLine("\nX={0}", vp);
            }
            else
            {
                sbyte vp = (sbyte)((-b + Math.Sqrt(d)) / (2 * a));
                sbyte vpp = (sbyte)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("\nvp={0}\nvpp={1}", vp, vpp);
            }
               

                             //QUESTION 5
            Console.WriteLine("--------QUESTION 5------");

            Console.WriteLine("Please write a number between 1 and 9: ");
            int input = int.Parse(Console.ReadLine());
 
            switch (input)
           {
              case 1:
              case 2:
              case 3:
                Console.WriteLine("The bonus point is: " + (input * 10));
                break;
              case 4:
              case 5:
              case 6:
                Console.WriteLine("The bonus point is: " + (input * 100));
                break;
              case 7:
              case 8:
              case 9:
                Console.WriteLine("The bonus point is: " + (input*1000));
                break;
              default:
                Console.WriteLine("Invalid Score!");
                break;
 
            }
            
                            //QUESTION 6
            Console.WriteLine("--------QUESTION 6--------");

              Console.WriteLine("Please enter your number: ");
             int n = int.Parse(Console.ReadLine());
 
             for (int i = 1; i <= n; i++)
            {
            if (i % 3 == 0)
            {
                continue;
            }
            else if (i % 7 ==0)
            {
                continue;
            }
            Console.Write("{0} ", i);
            }
             Console.WriteLine();

             //QUESTION 7
            Console.WriteLine("----------QUESTION 7------");
              for (int i = 2; i <= 14; i++)
            {
              for (int j = 5; j < 7; j--)
            {
                if (i < 11)
                {
                    Console.Write("{0}{1} ", i, (char)j);
                }
                switch (i)
                {
                    case 11: Console.Write("J{0} ", (char)j);
                        break;
                    case 12: Console.Write("Q{0} ", (char)j);
                        break;
                    case 13: Console.Write("K{0} ", (char)j);
                        break;
                    case 14: Console.Write("A{0} ", (char)j);
                        break;
                }
                if (j == 3)
                {
                    j = 7;
                }
                if (j == 6)
                {
                    break;
                }
            }
            Console.WriteLine();
            }

                              //QUESTION 8
             Console.WriteLine("----------QUESTION 8--------");

             Console.WriteLine("Please enter your number:");
             int num = int.Parse(Console.ReadLine());
 
             if (num == 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            else if (num == 1)
            {
                Console.WriteLine(0);
                return;
            }
 
             int x1 = 0;
             int x2 = 1;
             Console.Write("{0} {1} ", x1, x2);
 
            for (int i = 2; i < num; i++)
            {
               int x3 = x1 + x2;
               Console.Write("{0} ", x3);
               x1 = x2;
               x2 = x3;
            }
              Console.WriteLine();

                              //QUESTION 10
            Console.WriteLine("--------QUESTION 10 -------");

            int[] array = new int[20];
		    Random random = new Random();
		    for (int index = 1; index < array.Length; index++)
		    {
			     array[index] = random.Next(100) + 1;
		    }
		
		    foreach (int number in array)
		    {
			   Console.WriteLine(number + "\t" + number*5);
		    }

                              //QUESTION 11
            Console.WriteLine("--------QUESTION 11--------");

     		//Boolean isArrayEqual = true;


		    string[] arr1 = new string[5];
	    	string[] arr2 = new string[5];
            Console.Write("Enter the first array input: ");
            varstrArr1 =Console.ReadLine();
             arr1 = strArr1.Split(' ');
            Console.Write("Enter the second array input: ");
            var strArr2 = Console.ReadLine();
             arr2 = strArr2.Split(' ');

		    Console.WriteLine(arr1[0]==arr2[0]||arr1 [arr1.Length - 1] == arr2 [arr2.Length -1]);

     		
            
                    Console.WriteLine("-----------QUESTION 12--------");

            int pos = 0, bestpos = 0, bestlen = 0;
            int len = 1;
            int[] maxi = new int[12] { 2, 2, 3, 4, 5, 5, 5, 6, 9, 9, 9, 4 };
            for (int i = 0; i < maxi.Length - 1; i++)
            {
                if (maxi[i] == maxi[i+1])
                {
                    len++;
                    if (len > bestlen)
                    {
                        bestlen = len;
                        bestpos = pos;
                    }

                }
                else
                {
                    len = 1;
                    pos = i+1;
                }

            }
             for (int k = bestpos; k < bestlen + bestpos; k++)
                {
                    Console.Write("{0} ", maxi[k]);
                }
         


                            //QUESTION 13
            Console.WriteLine("-------QUESTION 13-------");
            int[] array12 = new int[6] { 3, 4, 3, 5, 5, 3 };
            int count = 1, tempCount;
            int frequentNumber = array12[0];
            int tempNumber = 0;
            for (int i = 0; i < (array12.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int j = 0; j < array12.Length ; j++)
                {
                    if (tempNumber == array12[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.",frequentNumber,count);

                      
           
                            //Question 14
             Console.WriteLine("--------QUESTION 14-------");

             Console.WriteLine("Hello World!");
             Console.Write("Enter Decimal number: ");
             int decInput = int.Parse (Console.ReadLine());
             Console.WriteLine("Binary number: {0}", Convert.ToString(decInput,2));


                            //QUESTION 15
             Console.WriteLine("---------QUESTION 15---------");

             Console.WriteLine("Enter Binary Number: ");
             string biInput = Console.ReadLine();
             Console.WriteLine("Decimal output: {0}", Convert.ToInt32(biInput,2));

                            //Question 16
           Console.WriteLine("--------QUESTION 16----------");

           Console.WriteLine("Dec to Hex: ");
           int decValue = int.Parse(Console.ReadLine());
           Console.WriteLine(string.Format("{0:x}", decValue));

                             //QUESTION 17
            Console.WriteLine("--------QUESTION 17----------"); 

            Console.WriteLine("Hex to Decimal: ");
            string hexValue = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(hexValue,16));

                             //QUESTION 18
            Console.WriteLine("--------QUESTION 18-------");

            Console.WriteLine("Hex to Binary: ");
            string hexInput = (Console.ReadLine());
            Console.WriteLine(Convert.ToString(Convert.ToInt64(hexInput,16), 2));

                              //QUESTION 19
            Console.WriteLine("---------QUESTION 19-------");

            Console.WriteLine("Binary TO hex: ");
            string biValue = (Console.ReadLine());
            Console.WriteLine(string.Format("{0:X2}", Convert.ToInt64(biValue,2)));

            //    QUESTION 20
            Console.WriteLine("------Question 20--------");
            
            int[,] numbers = new int[4,4];
            Console.WriteLine("Input the elements of the array: ");
            for(int m =0; m<4; m++)
            {
                for(int x =0; x<4; x++)
                {
                    Console.WriteLine("{0}: ",m);
                    numbers[m,x] =int.Parse(Console.ReadLine());
                }
            }
            for (int m = 0;m<4; m++)
            {
                for(int x = 0;x<3;x++)
                {
                Console.WriteLine(numbers[m,x] +" ");
                }
            }

        }

    }    
}

