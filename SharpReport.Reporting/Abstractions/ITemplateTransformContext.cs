using System.IO;

namespace SharpReport.Reporting.Abstractions
{
    public interface ITemplateTransformContext
    {
        object Data { get; }
        object Parameters { get; }
        ITemplateHost Host { get; }

        Stream ResultStream { get; }
    }
}