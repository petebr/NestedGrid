using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<NestedGrid.Default.MainRow>;
using MyRow = NestedGrid.Default.MainRow;

namespace NestedGrid.Default
{
    public interface IMainListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MainListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMainListHandler
    {
        public MainListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}