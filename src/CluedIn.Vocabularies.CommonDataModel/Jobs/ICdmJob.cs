using System.Threading;
using System.Threading.Tasks;

namespace CluedIn.Vocabularies.CommonDataModel.Jobs
{
    public interface ICdmJob
    {
        Task Run(CancellationTokenSource cancellationTokenSource);
    }
}
