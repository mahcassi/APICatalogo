
using Microsoft.Win32;

namespace APICatalogo.Logging
{
    public class CustomerLogger : ILogger
    {
        readonly string loggerName;
        readonly CustomLoggerProviderConfiguration loggerConfig;
        public CustomerLogger(string name, CustomLoggerProviderConfiguration config)
        {
            loggerName = name;
            loggerConfig = config;
        }
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            //verifica se o log esta habilitado conforme o nivel de configuracao
            return logLevel == loggerConfig.LogLevel;
        }

        //chamado para registrar uma mensagem de log
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string mensagem = $"{logLevel.ToString()}: {eventId.id} - {formatter(state, exception)}";

            EscreverTextoNoArquivo(mensagem);
        }


        private void EscreverTextoNoArquivo(string mensagem)
        {
            string caminhoArquivoLog = @"d:\dados\log\og_text.txt";

            using(StreamWriter streamWritter = new StreamWriter(caminhoArquivoLog, true))
            {
                try
                {
                    streamWritter.WriteLine(mensagem);
                    streamWritter.Close();
                } 
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
