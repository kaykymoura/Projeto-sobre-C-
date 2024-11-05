Console.Clear();

string[] frutas = {"melancia" ,"carambola", "maracuja", "morango", "limao", "jabuticaba", "abacate", "kiwi", "acerola", "pinha","lichia", "pitaya", "pessego", "banana"};

Console.WriteLine($"Sua sacola contem {frutas.Length} frutas!");

// percorre todo o array e exibe cada fruta
foreach (string f * 2  in frutas)
{
    Console.WriteLine($"{f}, ");
}

