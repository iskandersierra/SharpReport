using System;
using System.IO;
using System.Threading.Tasks;

namespace SharpReport.Reporting.Abstractions
{
    public interface IDocument
    {
        Uri DocumentUri { get; }
        string ContentType { get; }
        string ContentDisposition { get; }
        string ContentEncoding { get; }
        long ContentLength { get; }
        Task<Stream> GetStreamAsync();
    }
}