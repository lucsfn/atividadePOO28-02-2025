namespace util
{
    public class Logger
    {
        public readonly string LogFilePath;

        public Logger(string filePath)
        {
            this.LogFilePath = filePath;
        }

        public void Log(string message, string logLevel)
        {
            try
            {
                string logMessage = $"{DateTime.Now} [{logLevel}] {message}";

                using (StreamWriter writer = new StreamWriter(LogFilePath, true))
                {
                    writer.WriteLine(logMessage);
                }

                Console.WriteLine(logMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar log: {ex.Message}");
            }
        }

        public void LogError(string message)
        {
            Log(message, "ERRO");
        }

        public void LogSuccess(string message)
        {
            Log(message, "SUCESSO");
        }

        public void LogWaiting(string message)
        {
            Log(message, "ESPERA");
        }

    }
}