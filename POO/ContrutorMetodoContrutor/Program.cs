using ContrutorMetodoContrutor;

// Carro c1 = new Carro("Toyta", "Corolla", 2022);
// c1.exibirDados();
// Console.WriteLine();

Aluno a1 = new Aluno();
Aluno a2 = new Aluno("Henrique", 10);

System.Console.WriteLine(@$"Aluno 1 : 
Nome : {a1.Nome}
Nota : {a1.Nota}");

System.Console.WriteLine(@$"Aluno 2 :
Nome : {a2.Nome}
Nota : {a2.Nota}");


// MediaAluno a1 = new MediaAluno(6, 7, 8);

// a1.Nome = "Henrique";
// a1.Media();

// MediaAluno a2 = new MediaAluno();
// a2.Nome = "Samuel";
// a2.Media();