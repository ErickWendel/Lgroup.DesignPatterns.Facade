using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Facade.Business;
using LGroup.Facade.Model;
using LGroup.Facade.Helper;

namespace LGroup.Facade
{
    //PROBLEMA
    //sempre que no dia a dia tivermos muitas classes e metodos para chamar, inclusive de varios sistemas
    //podemos facilitar implementando o  padrão FACADE (GoF), padão muito utilizado

    //PROPOSTA
    //Diminuir a complexidade ao acesso aos componentes(DLLS)
    //Criamos uma FACHADA mais Simples para algo mais COMPLEXO
    //Fica facil de chamar, e não precisamos saber o que está acontecendo la dentro
    public sealed class ContatoFacade
    {
        public void IniciarProcessamento(ContatoModel contato_) {
            var negociarCOntato = new ContatoBusiness();
            negociarCOntato.ValidarCamposObrigatorios(contato_);
            EmailHelper.Enviar("aula.padroes@gmail.com", "aula.padroes@gmail.com", "test", "MENSAGEM ERICK");
            
            ArquivoHelper.GravarLog("Gravado com sucesso");
        }
    }
}
