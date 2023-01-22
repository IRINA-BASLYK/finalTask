/* Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string [] arrayFirst = new string[8] {"hello", "task", "work", "abs", "88", "ok", "1", "Ira" };
string [] arraySecond = new string [arrayFirst.Length];

for( int i = 0; i< arrayFirst.Length; i++){
    if( arrayFirst[i].Length<=3) 
    i++;
}    
    
void FillArray(){
    int j = 0;
    for( int i = 0; i< arrayFirst.Length; i++){
        if ( arrayFirst[i].Length <=3){
            arraySecond[j] = arrayFirst[i];
            j++;
        }
    }
}

void PrintArray(){
    for (int i = 0; i < arraySecond.Length; i++){
        if (i < arraySecond.Length - 1) 
        Console.Write($"{arraySecond[i]}  ");
        else 
        Console.Write(arraySecond[i]);
    }
    Console.WriteLine();
}
FillArray();
PrintArray();

