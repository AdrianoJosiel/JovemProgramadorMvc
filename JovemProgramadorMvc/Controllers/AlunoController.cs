﻿using JovemProgramadorMvc.Data.Repositorio.Interfaces;
using JovemProgramadorMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMvc.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;                   
        
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }
        public IActionResult AdicionarAluno()
        {
           return View();
        }
        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.InserirAluno(aluno);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
