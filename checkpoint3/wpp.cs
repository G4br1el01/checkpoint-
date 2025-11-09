using System;

namespace ChatApp
{
    public class WhatsApp : ChannelBase
    {
        public string NumeroTelefone { get; private set; }

        public WhatsApp(string numero) : base("WhatsApp")
        {
            NumeroTelefone = numero;
        }

        public override void EnviarMensagem(MessageBase mensagem)
        {
            Console.WriteLine($"=== Enviando via {NomeCanal} ===");
            Console.WriteLine($"Para: {NumeroTelefone}");
            Console.WriteLine(mensagem.FormatMessage());
            Console.WriteLine("==============================\n");
        }
    }
}
