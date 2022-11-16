using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<NestedGrid.Default.ChildBRow>;
using MyRow = NestedGrid.Default.ChildBRow;

namespace NestedGrid.Default
{
    public interface IChildBListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildBListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IChildBListHandler
    {
        public ChildBListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}