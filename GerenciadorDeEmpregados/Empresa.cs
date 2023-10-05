using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEmpregados
{
    internal class Empresa
    {
        private List<Empregado> empregados = new(); // inicializa lista de empregados  


        internal void Cadastrar(Empregado empregado)
        {
            empregados.Add(empregado);
        }
        //private static void Promover(Empregado.Nome, Empregado.Sobrenome)
        //{
        //    return;
        //}
        //private static void Demitir(Empregado.Nome, Empregado.Sobrenome)
        //{
        //    return;
        //}
    }
}
