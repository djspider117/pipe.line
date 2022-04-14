namespace Pipeline.Data
{
    public class PipelineDefinition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PipelineTrigger> Triggers { get; set; }
        public List<PipelineStep> Steps { get; set; }

        public PipelineDefinition(string name)
        {
            Name = name;
            Triggers = new List<PipelineTrigger>();
            Steps = new List<PipelineStep>();
        }
    }
}