using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Facade.Model.Base;

//na programacao existe um termo chamado CODE REFACTORY ou REFATORACAO DE CODIGO
//significa analisar o codigo, visando boas praticas, padroes de projeto e performance
//PONTOS DE MELHORIA
//1 - CRIAR UMA SUPER CLASSE

namespace LGroup.Facade.Model
{
    public sealed class ContatoModel : BaseModel
    {
        public Int32 CodigoSexo { get; set; }
        public Int32 CodigoEstadoCivil { get; set; }
        public string Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        //da mesma forma que as tabela se relacionam, devemos relacionar as nossas classes.
        //isso no UML chama-se ASSOCIACAO
        //devemos entao associar as classes

        public EstadoCivilModel EstadoCivil { get; set; }
        public SexoModel Sexo { get; set; }
    }
}
