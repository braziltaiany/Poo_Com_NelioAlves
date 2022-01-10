using System;
using System.Collections.Generic;
using System.Text;

namespace TransacaoBancaria_TratamentoDeExcecoes.Entities.Exceptions
{
    class DomainExcepiton : ApplicationException 
    {
        public DomainExcepiton(string message) : base(message)
        {

        }
    }
}
