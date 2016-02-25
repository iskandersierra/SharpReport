using System.Threading.Tasks;

namespace SharpReport.Reporting.Abstractions
{
    public interface IDocumentTranslator
    {
        Task TranslateAsync(IDocumentTranslationContext context);
    }
}
