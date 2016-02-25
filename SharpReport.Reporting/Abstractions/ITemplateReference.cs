using System;
using System.Threading.Tasks;

namespace SharpReport.Reporting.Abstractions
{
    public interface ITemplateReference
    {
        Uri TemplateUri { get; }

        Task<ITemplate> GetTemplateAsync();
    }
}