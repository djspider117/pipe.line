namespace Pipeline.Data
{
    public interface IPipelineStepOutputData
    {
        public abstract string Typename { get; }
    }

    public class CompositePipelineData : IPipelineStepOutputData
    {
        public string Typename => nameof(CompositePipelineData);
        public List<IPipelineStepOutputData> Children { get; set; } = new List<IPipelineStepOutputData>();
    }
}