﻿using System;
using System.Linq;
using MBCorpHealthTest.Dominio.Fabricas;
using MBCorpHealthTest.Dominio.Servicos;
using MBCorpHealthTest.Infraestrutura;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMedicos = MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos.IMedicos;

namespace MBCorpHealthTestTest
{
    [TestClass]
    public class TestesIntegradosContextoAdministracaoDeAgendamentosDeExame
    {       

        [TestMethod]
        public void ComoPacienteQueroConsultarOResultadoDosMeusExamesIntegrado()
        {
            //using (var session = NHibernateSessionFactory.Criar().OpenSession())
            //{
            ////Assert
            //IAgendamentos agendamentos = new Agendamentos(session);

            
            //    //Arrange
            //    Agendamento agendamento =
            //        agendamentos.pesquisarPorPaciente((new Credencial("fabiomargarito@gmail.com", "1234")));

            //    //Assert
            //    Assert.IsTrue(agendamento.Exames.First().Laudo.Descricao == "teste");
            //}
        }

        [TestMethod]
        public void DevePersistirOAgendamentoIntegrado()
        {
            //using (var session = NHibernateSessionFactory.Criar().OpenSession())
            //{
            //    //Arrage
            //    Agendamento agendamento =
            //        (new FabricaDeAgendamento()).InformarPaciente("1234")
            //            .InformarMedicoSolicitante("123")
            //            .InformarAtendente("222")
            //            .Criar();

            //    agendamento.AdicionarExame(new Exame(new TipoExame("1", "Hemograma", 100)));
            //    agendamento.Credencial = (new ServicoDeGeracaoCredencial()).Gerar(agendamento.Paciente);

            //    IAgendamentos agendamentos = new Agendamentos(session);

            //    //Act
            //    var retorno = agendamentos.Gravar(agendamento);

            //    //Assert
            //    Assert.IsTrue(retorno);
            }

        [TestMethod]
        public void DeveConsultarServicoDeAgendaDasUnidadesDeDiagnostico()
        {
            
        }

    }

    }
    
    
    

