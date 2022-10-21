using UniversidadeF;

Alunos aluno10011 = new Alunos();

aluno10011.matricula = 10011;
aluno10011.nome_aluno = "Amanda Rodriguês";
aluno10011.UF = "DF";
aluno10011.tipo_curso = "Bacharelado";
aluno10011.nome_curso = "Ciência de Dados";
aluno10011.polo = "Riacho Fundo";
aluno10011.modaliade_ensino = "EAD";



Console.WriteLine("Matrícula: " + aluno10011.matricula);
Console.WriteLine("Nome: " + aluno10011.nome_aluno);
Console.WriteLine("UF: " + aluno10011.UF);
Console.WriteLine("Tipo do Curso: " + aluno10011.tipo_curso);
Console.WriteLine("Curso: " + aluno10011.nome_curso);
Console.WriteLine("Polo da matrícula: " + aluno10011.polo);
Console.WriteLine("Modalidade de ensino: " + aluno10011.modaliade_ensino);

//Troca
aluno10011.TrocarPolo("Águas Claras");
Console.WriteLine(aluno10011.polo);
Console.WriteLine();

//Se
if(aluno10011.MudarSe(10012) == true)
{
    Console.WriteLine("Bem vindo de volta!" + aluno10011.nome_aluno);
}
else
{
    Console.WriteLine("Matrícula não encontrada. Tente novamente.");
}








