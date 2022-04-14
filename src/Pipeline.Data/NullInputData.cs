namespace Pipeline.Data
{
    public class NullInputData : IPipelineStepInputData
    {
        public string Typename => nameof(NullInputData);
    }
}