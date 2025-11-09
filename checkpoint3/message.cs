using System;

namespace ChatApp
{
    // Classe base abstrata - demonstra herança e encapsulamento
    public abstract class MessageBase
    {
        public string Conteudo { get; private set; }
        public DateTime DataEnvio { get; private set; }

        protected MessageBase(string conteudo)
        {
            Conteudo = conteudo;
            DataEnvio = DateTime.Now;
        }

        // Método abstrato usado no polimorfismo
        public abstract string FormatMessage();
    }
}
