// Exercício prático 24_09 - Menu e Lista

using System.Collections.Generic;
int averageScore = 5;

if(averageScore >= 5){
    Console.WriteLine("Nota suficiente para aprovação");
}
else{
    Console.WriteLine("Nota insuficiente para aprovação");
}

List<string> languanges = new List<string> {"C#","Java","JS"};

Console.WriteLine(languanges[0]);

void SearchPosition(int a){
    if (a > 2){
        Console.WriteLine("Não há nada nessa posição");
    }
    else{
        Console.WriteLine($"A linguagem nessa posicção é: {languanges[a]}");
    }
}

void ReadPosition(){
    Console.Write("Qual a posição vc quer saber? ");
    int num = int.Parse(Console.ReadLine());
    SearchPosition(num);
}

ReadPosition();
