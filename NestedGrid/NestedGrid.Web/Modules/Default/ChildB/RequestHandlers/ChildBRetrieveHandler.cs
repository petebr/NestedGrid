using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<NestedGrid.Default.ChildBRow>;
using MyRow = NestedGrid.Default.ChildBRow;

namespace NestedGrid.Default
{
    public interface IChildBRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildBRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IChildBRetrieveHandler
    {
        public ChildBRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}