//instanciar uma universidade 
Universidade objUniversidade = new Universidade();
objUniversidade.nome = "Up";
objUniversidade.localicacao = "Ecoville";
objUniversidade.anoFundacao = 1990;
//criar o cursso ADS e adicionar na universidade
Curso objCurso = new Curso();
objCurso.nome = "ADS";

objUniversidade.AdicionarCurso(objCurso);

objCurso = new Curso();
objCurso.nome = "BSI";
objUniversidade.AdicionarCurso(objCurso);

Console.WriteLine(objUniversidade.nome);
foreach (var curso in objUniversidade.cursos)
{
    Console.WriteLine(curso.nome);
}
