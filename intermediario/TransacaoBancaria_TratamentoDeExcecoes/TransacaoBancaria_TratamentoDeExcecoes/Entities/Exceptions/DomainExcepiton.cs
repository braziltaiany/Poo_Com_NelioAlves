using System;
using System.Collections.Generic;
using System.Text;

namespace TransacaoBancaria_TratamentoDeExcecoes.Entities.Exceptions
{
    class DomainExcepiton : AplicationExeption
    {
        public DomainExcepiton(string message) : base(message)
        {

        }
    }
}
