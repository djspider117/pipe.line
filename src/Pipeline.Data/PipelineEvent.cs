namespace Pipeline.Data
{
    public class PipelineEvent
    {
        public string Name { get; set; }
        public string? Payload { get; set; }

        public PipelineEvent(string name)
        {
            Name = name;
        }
    }
}