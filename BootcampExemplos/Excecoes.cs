using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampExemplos
{
    public class Excecoes
    {
        public void ExcecoesComTryCatch ()
        {
            try 
            {
            string[] linhas = File.ReadAllLines("../../../Arquivos/arquivoLeitura.txt");

            foreach(string linha in linhas) 
            {
                Console.WriteLine(linha);
            }
            } 

            catch(FileNotFoundException ex) 
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado."
                + "\n {ex.Message}");
            }

            catch(DirectoryNotFoundException ex) 
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado."
                + "\n {ex.Message}");
            }

            catch(Exception ex) 
            {
                Console.WriteLine($"Ocorreu uma exceção genérica; {ex.Message}");
            }

        }
    }
}