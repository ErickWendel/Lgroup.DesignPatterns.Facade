using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Facade.Model.Base;


//PADROES SAO FORMAS ELEGANTES DE RESOLVER PROBLEMAS
//OU SITUACOES COTIDIANAS
//NO DESENVOLVIMENTO DE SOFTWARE CHAMAMOS DE 
//PADROES DE PROJETO OU DESIGN PATERNS
//DADA 1 PROBLEMA NO CODIGO EH INVENTADO 1 PADRAO
//UMA SOLUCAO ELEGANTE PRA RESOLVER AQUELE PROBLEMA OU SITUACAO
//OS PADROES TIVERAM INICIO EM 77, COM C++... FOI PRA JAVA E RESPINGOU NO .NET
//UM DOS MELHORES CATALOGS DE PADROES DO MUNDO EH O 'GOF'(GANGUE DOS QUATRO) QUE EH DE 95
//AO TODO SAO 23 PADORES
//OS PRINCIPAIS PENSADORES DO ASSUNTO SAO MARTINS FOWLER E UNCLE BOB
//MODEL NAO EH UM PADRAO DE PROJETO, EH UM TERMO ARQUITETURAL
//SIGNIFICA ARMAZENAMENTO DE DADOS E ACESSO A DADOS


namespace LGroup.Facade.Model
{
    //uma classe sem modificador de acesso, é uma classe INTERNAL
    //NAO EH PRIVATE
    //INTERNAL siginifica que ser visivel somente naquela DLL
    //DLL == COMPONENTE

    //o modificador SEALED bloqueia a classe para que não possa ser HERDADA
    //a maquina virtual(CLR) otimiza o acesso, ou seja, acessa mais rapido CLASSES FECHADAS(SEALED)
    //dessa forma ganha-se performance com isso
    public sealed class SexoModel:BaseModel
    {
        public String Descricao { get; set; }

    }
}
