// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// string  UserInputNewWords = new string (Console.ReadLine());
string [] UserInputNewWords = ["Hello", "2", "wor", ":-)"];
int countSymbol = 0;
int taskNeed = 3;
string temp;
string [] outputTask= [];

for (int i = 0; i < UserInputNewWords.Length; i++)
{
    temp = UserInputNewWords[i];
    if (temp.Length <= taskNeed)
    {
        countSymbol +=1;
        // System.Console.Write(UserInputNewWords[i] + " ");
        string [] TempOutputList = CreateNewList(countSymbol, UserInputNewWords[i], outputTask);
        outputTask =  TempOutputList;
    }
}
PrintList(outputTask);

static string [] CreateNewList( int countSymbol, string informationForSave, string [] outputTask)
{
    
    string [] TempOutputList = new string [countSymbol];
    for (int i = 0; i < outputTask.Length; i++)
    {
        TempOutputList[i] = outputTask[i];
    }
    TempOutputList [countSymbol-1] = informationForSave;
    return TempOutputList;
}

static void PrintList(string [] outputTask)
{
    System.Console.Write("[ ");

    for (int i = 0; i < outputTask.Length; i++)
    {
        if(i< outputTask.Length -1)
        {
            System.Console.Write(outputTask[i] +", ");

        }
        else
        {
            System.Console.Write(outputTask[i]);
        }
    }

    System.Console.Write(" ]");

}