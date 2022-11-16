using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<NestedGrid.Default.ChildARow>;
using MyRow = NestedGrid.Default.ChildARow;

namespace NestedGrid.Default
{
    public interface IChildAListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildAListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IChildAListHandler
    {
        public ChildAListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}