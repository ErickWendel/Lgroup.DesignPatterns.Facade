using LGroup.Facade.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NUNIT
//existem diversos frameworks de testes no mercado
//a propria Microsoft tem o seu framework, o VSUT(Visual Studio Unite Test Framework)
//O framework mais usado no mundo eh o NUNIT

namespace LGroup.Facade.UnitTest
{
    [TestFixture]
    public sealed class ComFacadeTest
    {
        [Test]
        public void Testar_Camadas_Com_Padrao_Facade()
        {
            var novoContato = new ContatoModel();
            novoContato.Nome = "Zeh";
            novoContato.Email = "Email01";
            var contatoFacade = new ContatoFacade();
            contatoFacade.IniciarProcessamento(novoContato);
        }
        
    }
}
