using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.CONTROL
{
    public class Validacao
    {
        #region Metodos de Validacao
        public string validaCampos(MODEL.Table Livro, string ano, string estoque, string pag)
        {
            string msg = string.Empty;
            if (Livro.Autor.Equals(string.Empty))
            {
                msg = "Por favor informe um autor.";
                return msg;
            }

            if (Livro.Editora.Equals(string.Empty))
            {
                msg = "Por favor informe uma Editora";
                return msg;
            }

            if (Livro.Livro.Equals(string.Empty))
            {
                msg = "Por favor informe um Livro";
                return msg;
            }

            int Verificaint;

            if (!int.TryParse(pag.ToString(), out Verificaint))
            {
                msg = "Por favor informe uma quantidade de páginas válida.";
                return msg;
            }

            if (!int.TryParse(estoque.ToString(), out Verificaint))
            {
                msg = "Por favor informe uma quantidade de estoque válida.";
                return msg;
            }

            if (!int.TryParse(ano.ToString(), out Verificaint))
            {
                msg = "Por favor informe um ano válido.";
                return msg;
            }
            return msg;
        }
        #endregion
    }
}
