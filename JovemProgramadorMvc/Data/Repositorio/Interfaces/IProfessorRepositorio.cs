using JovemProgramadorMvc.Models;

namespace JovemProgramadorMvc.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessor();
        void InserirProfessor(Professor professor);
        void EditarProfessor(Professor professor);
        Professor BuscarId(int id);
        void Excluir(Professor professor);

    }
}
