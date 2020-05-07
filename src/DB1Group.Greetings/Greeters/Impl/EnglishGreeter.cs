namespace DB1Group.Greetings.Greeters.Impl
{
    public class EnglishGreeter : IMultiLanguageGreeters
    {
        public string Greetings(string personName)
        {
            return $"Hello, {personName}";
        }
    }
}