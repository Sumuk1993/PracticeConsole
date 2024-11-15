// See https://aka.ms/new-console-template for more information


//int[] a = new int[3];

//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine("Enter Values for Array Index:" + i);
//    a[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Array Values");
//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine("index:" + i + "-" + a[i]);
//}

//string[] a = new string[3];

//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine("Enter Values for Array Index:" + i);
//    a[i] = Console.ReadLine();
//}

//Console.WriteLine("Array Values");
//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine("index:" + i + "-" + a[i]);
//}

//Console.WriteLine("Enter Subject Count");
//int cnt = int.Parse(Console.ReadLine());
//int[] marks = new int[cnt];

//int sum = 0;
//for (int i = 0; i < marks.Length; i++)
//{
//    Console.WriteLine("Enter Subject Marks:" + i);
//    marks[i] = int.Parse(Console.ReadLine());
//    sum = sum + marks[i];
//}

//for (int i = 0; i < marks.Length; i++)
//{
//    Console.WriteLine("Subject Marks:" + i + "-" + marks[i]);
//}

//Console.WriteLine("Total Score:" + sum);

//-----------------------------*****************************************-------------------------------------//

//Console.WriteLine("Enter Subject Count");
//int cnt = int.Parse(Console.ReadLine());
//int[] marks = new int[cnt];

//int sum = 0;
//int cnts = 0;
//foreach (var xyz in marks)
//{
//    Console.WriteLine("Enter Subject Marks:" + cnts);
//    var cd = int.Parse(Console.ReadLine());
//    marks[cnts++] = cd;
//    sum = sum + cd;
//}
//Console.WriteLine("Subject Marks List");
//int count = 0;
//foreach (int xyz in marks)
//{
//    Console.WriteLine("Subject Marks:" + count++.ToString() + " " + xyz);
//}

//Console.WriteLine("Total Score:" + sum);

//---------------------------------------****************************-----------------------------------------------------

//Console.WriteLine("Enter Subject Count");
//int cnt = int.Parse(Console.ReadLine());
//int[] marks = new int[cnt];

//int sum = 0;
//int cnts = 0;
//foreach (var xyz in marks)
//{
//    Console.WriteLine("Enter Subject Marks:" + cnts);
//    var cd = int.Parse(Console.ReadLine());
//    marks[cnts++] = cd;
//    sum = sum + cd;
//}
//Console.WriteLine("Subject Marks List");
//int count = 0;
//foreach (int xyz in marks)
//{
//    Console.WriteLine("Subject Marks:" + count++.ToString() + " " + xyz);
//}

//Console.WriteLine("Total Score:" + sum);

//----------------------------------------------------------****************************---------------------------------

Console.WriteLine("Enter Subject Count");
int cnt = int.Parse(Console.ReadLine());
int[] marks = new int[cnt];

int sum = 0, cnts = 0;
foreach (var xyz in marks)
{
    if (sum < 100)
    {
        Console.WriteLine("Enter Subject Marks:" + cnts);
        var cd = int.Parse(Console.ReadLine());
        marks[cnts++] = cd;
        sum = sum + cd;
    }
    else if (sum > 100)
    {
        Console.WriteLine("reached 100 score: " + sum);
        break;
    }
}
Console.WriteLine("Subject Marks List");
int count = 0;
foreach (int xyz in marks)
{
    Console.WriteLine("Subject Marks:" + count++.ToString() + " " + xyz);
}
Console.WriteLine("Total Score:" + sum);


//-----------------------------------------------------------****************************----------------------------------

//ArrayList mrks = new ArrayList();
//List<int> mrks = new List<int>();

//Console.WriteLine("Enter Subject Count");
//int cnt = int.Parse(Console.ReadLine());
//int[] marks = new int[cnt];

//int sum = 0, cnts = 0;
//foreach (var xyz in marks)
//{
//    if (sum < 100)
//    {
//        //Console.WriteLine("Enter Subject Marks:" + cnts++);

//        Console.WriteLine("Enter Subject Marks:" + cnts);                    
//        var cd = int.Parse(Console.ReadLine());
//        //mrks.Add(cd);
//        marks[cnts++] = cd;
//        sum = sum + cd;
//    }
//    else if (sum > 100)
//    {
//        Console.WriteLine("reached 100 score: " + sum);
//        break;
//    }
//}
//Console.WriteLine("Subject Marks List");
//int count = 0;
//foreach (int xyz in marks)
//{
//    Console.WriteLine("Subject Marks:" + count++.ToString() + " " + xyz);
//}
//Console.WriteLine("Total Score:" + sum);

//-----------------------------------------------------------****************************---------------------
//Console.WriteLine("Enter Subject Count");
//int cnt = int.Parse(Console.ReadLine());
//int[] marks = new int[cnt];

//bool isskip = false;
//int sum = 0, cnts = 0;
//foreach (var xyz in marks)
//{
//    if (sum < 100)
//    {
//        Console.WriteLine("Enter Subject Marks:" + cnts);
//        var cd = int.Parse(Console.ReadLine());
//        marks[cnts++] = cd;
//        sum = sum + cd;
//    }
//    else if (sum > 100)
//    {
//        Console.WriteLine("reached 100 score: " + sum);
//        break;
//    }
//}
//Console.WriteLine("Subject Marks List");
//int count = 0;
//foreach (int xyz in marks)
//{

//    if (isskip)
//    {
//        Console.WriteLine("Subject Marks:" + count.ToString() + " " + xyz);
//    }
//    isskip = !isskip;
//    count++;
//}
//Console.WriteLine("Total Score:" + sum);
