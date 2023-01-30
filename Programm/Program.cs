
// Создание массива строк
static string[] CreateArray(int args)
    {
        return new string[args];
    }






string [] M = {"rsat", "ls", "1", "112", "1л11"};
string [] N = CreateArray (M.Length);

int index = 0;

for (int i = 0; i < M.Length; i++)
{
if (M[i].Length <= 3)


N[index] = M[i];
index++;

}


PrintArray (N);















