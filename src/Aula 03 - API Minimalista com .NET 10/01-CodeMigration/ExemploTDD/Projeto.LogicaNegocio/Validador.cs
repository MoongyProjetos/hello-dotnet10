using System;

namespace Projeto.LogicaNegocio
{
    public class Validador
    {
        public bool ValidarNif(string param)
        {
            if (param.Length != 9 || param[0] == '1')
                return false;

            return true;
        }
    }
}
