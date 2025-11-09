using System;

namespace ChatApp
{
    public class Facebook : ChannelBase
    {
        public string Usuario { get; private set; }

        public Facebook(string usuario) : base("Facebook")
        {
            Usuario = usuario;
        }

        public override void EnviarMensagem(MessageBase mensagem)
        {
            Console.WriteLine($"=== Enviando via {NomeCanal} ===");
            Console.WriteLine($"Para usuário: @{Usuario}");
            Console.WriteLine(mensagem.FormatMessage());
            Console.WriteLine("==============================\n");
        }
    }
}
