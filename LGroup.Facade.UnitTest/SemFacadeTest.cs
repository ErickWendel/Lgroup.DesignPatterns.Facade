using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//subimos o NUnit para memoria
using NUnit.Framework;
//por padrao, o NUnit nao se integra ao Visual Studio, para que isso aconteca
//para que isso aconteca, baixos o NUnit Teste Adapter

using LGroup.Facade.Business;
using LGroup.Facade.Helper;
using LGroup.Facade.Model;

#warning PARAMOS AQUI, VOLTAR NA INTEGRAÇÃO DO TEST ADAPTER

namespace LGroup.Facade.UnitTest
{
    //eh adicionada um atributo, uma anotacao (configuracao), falando pro VS que essa é uma classe de testes.
    //Isso eh chamado de TESTE AUTOMATIZADO
    //Codigos testando Codigos
    [TestFixture]
    public sealed class SemFacadeTest
    {
        [Test]
        public void Testar_Camadas_Sem_Padrao_Facade() 
        {
        
            //PASSO 1 - Armazenar os dados
            var novoContato = new ContatoModel();
            novoContato.Nome = "Zeh";
            novoContato.Email = "Email01";

            //PASSO 2 - Validação dos dados
            var negocioContato = new ContatoBusiness();
            negocioContato.ValidarCamposObrigatorios(novoContato);

            //PASSO 3 - Enviar o email
            EmailHelper.Enviar("erick.workspace@gmail.com", "aula.padroes@gmail.com", "Sem facade", "Sem facade");

            //PASSO 4 - Gravar o log
            ArquivoHelper.GravarLog("Gravado com sucesso");
        }
    }
}
