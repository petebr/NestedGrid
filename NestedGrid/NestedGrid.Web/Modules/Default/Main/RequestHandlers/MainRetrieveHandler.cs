using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<NestedGrid.Default.MainRow>;
using MyRow = NestedGrid.Default.MainRow;

namespace NestedGrid.Default
{
    public interface IMainRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MainRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMainRetrieveHandler
    {
        public MainRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}