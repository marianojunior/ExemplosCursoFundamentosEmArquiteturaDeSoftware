﻿using System.Collections.Generic;
using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    public   class Pacientes:IPacientes
    {
        public virtual  IList<Paciente> PesquisarPacientePorTrechoDoNome(string nome)
        {
            IList<Paciente> pacientes = new List<Paciente>();
            pacientes.Add( new Paciente("123","Fabio","fabiomargarito@gmail.com"));
            return pacientes;
        }
        public virtual  Paciente pesquisarPacientePorCPF(string cpf)
        {
            return new Paciente("123", "Fabio", "fabiomargarito@gmail.com");
        }
        public virtual  bool Gravar(Paciente paciente)
        {
            return true;
        }
    }
}