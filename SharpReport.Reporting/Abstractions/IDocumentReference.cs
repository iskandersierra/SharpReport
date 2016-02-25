using System;
using System.Threading.Tasks;

namespace SharpReport.Reporting.Abstractions
{
    public interface IDocumentReference
    {
        Uri DocumentUri { get; }

        Task<IDocument> GetDocumentAsync();
    }
}