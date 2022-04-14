namespace Pipeline.Data
{
    public class PipelineTrigger
    {
        public string WatchedEventName { get; set; }

        public PipelineTrigger(string watchedEventName)
        {
            WatchedEventName = watchedEventName;
        }
    }
}