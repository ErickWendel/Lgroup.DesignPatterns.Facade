using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LGroup.Facade.Helper
{
    public sealed class ArquivoHelper
    {
        public static void GravarLog(String mensagem_) {
            //criamos uma pasta pro Log

            Directory.CreateDirectory(@"D:\LGroup_Log");

            //geramos o arquivo de log
            using(var arquivo = new StreamWriter(@"D:\LGroup_Log.saida.txt"))
            {
                arquivo.WriteLine(mensagem_);
            }

        }
    }
}
