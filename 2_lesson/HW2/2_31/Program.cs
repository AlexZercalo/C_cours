// 3. Напишите программу, которая выводит третью цифру
//    заданного числа или сообщает, что третьей цифры нет.

void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    int tr_num = -1;
    string txt;
    
    while (num > 99)
    {
        tr_num = num % 10;        
        num = num / 10; 
    }
    txt = $"{tr_num}";
    if (tr_num == -1)
    {
        txt = "there is no third digit";        
    }
    Console.WriteLine(txt);    
}

ThirdNum(871);
ThirdNum(32579);
ThirdNum(37899);
ThirdNum(78);