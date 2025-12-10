public class ConfigReader
{
    public string FilePath
    {
        get => field ??= "data/config.json";
        set => field = value ?? throw new ArgumentNullException(nameof(value));
    }
}