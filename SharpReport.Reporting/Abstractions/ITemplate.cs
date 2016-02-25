using System.Threading.Tasks;

namespace SharpReport.Reporting.Abstractions
{
    public interface ITemplate
    {
        Task TransformAsync(ITemplateTransformContext context);
    }
}