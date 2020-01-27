namespace ShapeLib.Processor
{
    internal static class ProcessorFactory
    {
        public static IProcessor Create()
        {
            return new DefaultProcessor();
        }
    }
}