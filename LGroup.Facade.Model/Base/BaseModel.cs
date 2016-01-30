using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//o nome BASE eh um termo arquitetural
//indica que dentro desta pasta, temos classes ou interfaces PAIS(SUPER TIPOS)
//tudo que estiver duplicado, repetido em TODAS AS CLASSES são colocados dentro do SUPER TIPO(CLASSE BASE)
//esta classe é o PAI de todos os MODELS
namespace LGroup.Facade.Model.Base
{
    //quando criamos uma classe, podemos acionar(INICIALIZAR) a mesma de 2 formas:
    //1 - INSTANCIA -> NEW
    //2 - HERANCA -> :
    //normalmente classes PAI foram feitas para serem HERDADAS
    //quando colocamos ABASTRACT na CLASSE nao podemos dar NEW nela, NAO tem como INSTANCIAR, SOH PODEMOS HERDAR

    public abstract class BaseModel
    {
        public Int32 Codigo { get; set; }
    }
}
