namespace Pipeline.Data
{
    public class NullOutputData : IPipelineStepOutputData
    {
        public string Typename => nameof(NullOutputData);
    }
}