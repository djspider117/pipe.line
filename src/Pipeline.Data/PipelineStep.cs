using System.Linq;

namespace Pipeline.Data
{
    public class PipelineStep
    {
        public List<Type> InputTypes { get; set; }
        public List<Type> OutputTypes { get; set; }
        public PipelineStep? Next { get; set; }

        public PipelineStep()
        {
            InputTypes = new List<Type>();
            OutputTypes = new List<Type>();

            //var inputs = GetType().GetCustomAttributes(typeof(SuportsInputDataAttribute), true).AsEnumerable<SuportsInputDataAttribute>().Select(x => x.SupportedType;
        }

    }


    public interface IPipelineStepHandler<T> where T : PipelineStep
    {
        int Version { get; }

        public IPipelineStepOutputData Handle(T step, IPipelineStepInputData[] input);
    }
}