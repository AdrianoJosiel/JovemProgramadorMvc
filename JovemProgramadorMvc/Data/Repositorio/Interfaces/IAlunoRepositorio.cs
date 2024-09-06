using JovemProgramadorMvc.Models;

namespace JovemProgramadorMvc.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();
        void InserirAluno(Aluno aluno);
        Aluno BuscarId(int id);
        void Excluir(Aluno aluno);

    }
}
