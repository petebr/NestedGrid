using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = NestedGrid.Default.ChildARow;

namespace NestedGrid.Default
{
    public interface IChildADeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildADeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IChildADeleteHandler
    {
        public ChildADeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}