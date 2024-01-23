// Atribuindo variaveis
string[] alunos = ["João", "Thiago", "Bia", "Vilma"];

int[] notasJoao = [100, 80, 90, 90, 70, 100];
int[] notasThiago = [60, 80, 100, 90, 80, 90];
int[] notasBia = [70, 80, 80, 90, 50];
int[] notasVilma = [100, 100, 100, 90, 80];

int examesAtribuidos = 5;

string aprovado = "";

int[] pontuacaoAluno = [10];

Console.WriteLine("Aluno\t\tGrade\n");

// percorrendo a matriz alunos
foreach (string nome in alunos)
{
    string alunoAtual = nome;

    if(nome == "João") pontuacaoAluno = notasJoao;

    else if(nome == "thiago") pontuacaoAluno = notasThiago;

    else if(nome == "Bia") pontuacaoAluno = notasBia;

    else if(nome == "Vilma") pontuacaoAluno = notasVilma;

    int somaNotas = 0;
    decimal mediaNotas = 0;
    int atribuicoesGrade = 0;

    foreach(int nota in pontuacaoAluno)
    {
        atribuicoesGrade += 1;

        if(atribuicoesGrade <= examesAtribuidos)
            somaNotas += nota;
        else 
            somaNotas += nota / 10;
    }

    mediaNotas = somaNotas / examesAtribuidos;

    if (mediaNotas >= 97) aprovado = "A+" ;
    else if (mediaNotas >= 93) aprovado = "A" ;
    else if (mediaNotas >= 90) aprovado = "A-" ;
    else if (mediaNotas >= 87) aprovado = "B+" ;
    else if (mediaNotas >= 83) aprovado = "B" ;
    else if (mediaNotas >= 80) aprovado = "B-" ;
    else if (mediaNotas >= 77) aprovado = "C+" ;
    else if (mediaNotas >= 73) aprovado = "C" ;
    else if (mediaNotas >= 70) aprovado = "C-" ;
    else if (mediaNotas >= 67) aprovado = "D+" ;
    else if (mediaNotas >= 63) aprovado = "D" ;
    else if (mediaNotas >= 60) aprovado = "D-" ;
    else if (mediaNotas >= 60) aprovado = "F" ;

    Console.WriteLine($"{nome}\t\t{mediaNotas}\t{aprovado}");
}