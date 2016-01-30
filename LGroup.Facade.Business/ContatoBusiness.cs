using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//subimos a DLL pra memoria importando o NAMESPACE
using LGroup.Facade.Model;

namespace LGroup.Facade.Business
{

    public sealed class ContatoBusiness
    {
        //temos que validar algumas informacoes da classe de contato

        public void ValidarCamposObrigatorios(ContatoModel contato_)
        {
            if (string.IsNullOrWhiteSpace(contato_.Nome))
            {

                throw new ApplicationException("Informe o nome");
            }

            if (string.IsNullOrWhiteSpace(contato_.Email))
            {
                throw new ApplicationException("Informe o email");
            }
        }
    }
}
