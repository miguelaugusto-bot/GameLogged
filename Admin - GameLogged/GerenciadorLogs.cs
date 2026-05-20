using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Admin___GameLogged
{
    public static class GerenciadorLogs
    {
        private static readonly string path = @"D:\Repositorios\Uninove\Projetos\GameLogged\Admin - GameLogged\Logs.txt";

        public static void RegistrarLog(string mensagem)
        {
            try
            {
                string diretorioPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(diretorioPath))
                {
                    Directory.CreateDirectory(diretorioPath);
                }

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    string logFormato = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {mensagem}";
                    sw.WriteLine(logFormato);
                }
            }
            catch
            {
                //preciso fazer um log de erros para o caso de falha ao salvar o log, mas como não tenho onde salvar, vou deixar em branco por enquanto
            }
        }
    }
}
