using System;

//Random rnd = new Random();  
//int num = rnd.Next();
//Console.WriteLine(num);

//int[] myNum = new int[20];
//Random rnd_2 = new Random();
//int num = rnd_2.Next(1, 101);
//for (int i = 0; i < myNum.Length; i++)
//{
//    myNum[i] = rnd_2.Next(1, 101);
//    Console.WriteLine("Number include = {0} ", myNum[i]);
//}
//Console.WriteLine("array length of the random number is = {0} ", myNum.Length);


//// Sum the numbers in the Element;
//int myTotalArr = 0;
//for (int i = 0; i < myNum.Length ; i++)
//{
//    myTotalArr += myNum[i];
//}
//Console.WriteLine("The Total sum of the numbers in the element is = {0} ",  myTotalArr );

//int[] arr = new int[12];
//Random round = new Random(0);
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = round.Next(50, 120);
//}
//int totalNum = 0;
//for(int i = 0; i< arr.Length; i++)
//{
//    totalNum += arr[i];
//}
//Console.WriteLine("The total sum of generated array number is = {0} ", totalNum);

int[] num = new int[5];
Random numRnd =new Random();
for(int i = 0; i < num.Length; i++)
{
    
    num[i] = numRnd.Next(35, 88);
    Console.WriteLine("The Array is = {0}", num[i]);
}
int totalSumNum = 0;
for(int i = 0; i < num.Length; i++)
{
    totalSumNum += num[i];
}
Console.WriteLine("the total sum is = {0} ", totalSumNum);

// The above function, sum up numbers in an int array comprising of random numbers, with a specified size in the array, 