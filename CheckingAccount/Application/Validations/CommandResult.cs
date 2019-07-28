namespace CheckingAccount.API.Application.Validations
{
    public class CommandResult
    {
        public CommandResult(bool success, string mensagem = null)
        {
            Success = success;
            Mensagem = mensagem;
        }

        public bool Success { get; private set; }
        public string Mensagem { get; private set; }
    }
}
