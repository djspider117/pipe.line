namespace Pipeline.Data
{
    public class FilePathInputData : IPipelineStepInputData
    {
        public string Typename => nameof(FilePathInputData);
        public string? Path { get; set; }
    }
}