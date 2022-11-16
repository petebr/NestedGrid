using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<NestedGrid.Default.ChildARow>;
using MyRow = NestedGrid.Default.ChildARow;

namespace NestedGrid.Default
{
    public interface IChildARetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildARetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IChildARetrieveHandler
    {
        public ChildARetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}