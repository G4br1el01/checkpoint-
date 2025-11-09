using System;

namespace ChatApp
{
    // Classe abstrata base para canais
    public abstract class ChannelBase
    {
        public string NomeCanal { get; private set; }

        protected ChannelBase(string nome)
        {
            NomeCanal = nome;
        }

        // Método abstrato (polimorfismo)
        public abstract void EnviarMensagem(MessageBase mensagem);
    }
}
