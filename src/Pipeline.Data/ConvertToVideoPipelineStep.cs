namespace Pipeline.Data
{
    [SuportsInputData(typeof(FilePathInputData))]
    [SuportsOutputData(typeof(FilePathOutputData))]
    //[Implementation("Version 1", typeof(BasicConvertToVideoHandler)]
    //[Implementation("Version 2", typeof(UnityConvertToVideoHandler)]
    public class ConvertToVideoPipelineStep : PipelineStep
    {
        public int Bitrate { get; set; }
        public int TrimSecondsStart { get; set; }
        public int TrimSecondsEnd { get; set; }

        public ConvertToVideoPipelineStep()
        {

        }
    }
}