using System;

namespace ChatApp
{
    public class Telegram : ChannelBase
    {
        public string NumeroTelefone { get; private set; }
        public string Usuario { get; private set; }

        public Telegram(string numeroOuUsuario) : base("Telegram")
        {
            if (numeroOuUsuario.StartsWith("+"))
                NumeroTelefone = numeroOuUsuario;
            else
                Usuario = numeroOuUsuario;
        }

        public override void EnviarMensagem(MessageBase mensagem)
        {
            Console.WriteLine($"=== Enviando via {NomeCanal} ===");
            Console.WriteLine(NumeroTelefone != null ? $"Para: {NumeroTelefone}" : $"Para usuário: @{Usuario}");
            Console.WriteLine(mensagem.FormatMessage());
            Console.WriteLine("==============================\n");
        }
    }
}
