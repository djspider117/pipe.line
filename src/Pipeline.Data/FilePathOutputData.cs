namespace Pipeline.Data
{
    public class FilePathOutputData : IPipelineStepOutputData
    {
        public string Typename => nameof(FilePathOutputData);
        public string? Path { get; set; }
    }
}