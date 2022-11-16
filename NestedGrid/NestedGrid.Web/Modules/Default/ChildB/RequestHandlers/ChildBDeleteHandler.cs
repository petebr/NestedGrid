using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = NestedGrid.Default.ChildBRow;

namespace NestedGrid.Default
{
    public interface IChildBDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildBDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IChildBDeleteHandler
    {
        public ChildBDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}