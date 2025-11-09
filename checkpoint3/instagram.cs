using System;

namespace ChatApp
{
    public class Instagram : ChannelBase
    {
        public string Usuario { get; private set; }

        public Instagram(string usuario) : base("Instagram")
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
