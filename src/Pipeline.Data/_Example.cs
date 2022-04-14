namespace Pipeline.Data
{
    class _Example
    {
        [SuportsInputData(typeof(FilePathInputData))]
        [SuportsOutputData(typeof(NullOutputData))] //todo make special attribute
        public class UploadToSoundCloudPipelineStep : PipelineStep
        {
            public string? ApiKey { get; set; }
            public DateTime ScheduledDate { get; set; }
            public bool InstaRelease { get; set; }
        }

        [SuportsInputData(typeof(FilePathInputData))]
        [SuportsOutputData(typeof(NullOutputData))]
        public class UploadToMixcloudCloudPipelineStep : PipelineStep
        {
            public string? ApiKey { get; set; }
            public string? TracklistFilePattern { get; set; }
        }

        [SuportsInputData(typeof(FilePathInputData))]
        [SuportsOutputData(typeof(NullOutputData))]
        public class UploadToYoutubePipelineStep : PipelineStep
        {
            public string? ApiKey { get; set; }
            public string? VideoNameTemplate { get; set; }
        }

        [SuportsAnyInputData]
        [SuportsOutputData(typeof(CompositePipelineData))]
        public class JoinPipelineStep : PipelineStep
        {
            public int TimeoutSeconds { get; set; }
        }

        public class TriggerEventPipelineStep : PipelineStep
        {
            public string EventName { get; set; }
            public string? Payload { get; set; }

            public TriggerEventPipelineStep(string eventName, string? payload = null)
            {
                EventName = eventName;
                Payload = payload;
            }
        }

        public _Example()
        {
            var def = new PipelineDefinition("myPipe");
            def.Triggers.Add(new PipelineTrigger("ManualRunInvoked"));

            var convert = new ConvertToVideoPipelineStep();
            var upl_yt = new UploadToYoutubePipelineStep();
            convert.Next = upl_yt;

            var upl_sc = new UploadToSoundCloudPipelineStep();
            var upl_mc = new UploadToMixcloudCloudPipelineStep();


            var upl_join = new JoinPipelineStep
            {
                TimeoutSeconds = 7200,
                Next = new TriggerEventPipelineStep("StartSocialMediaPipeline")
            };

            upl_sc.Next = upl_join;
            upl_yt.Next = upl_join;
            upl_mc.Next = upl_join;

            def.Steps.Add(upl_sc);
            def.Steps.Add(upl_mc);
            def.Steps.Add(convert);

        }
    }
}