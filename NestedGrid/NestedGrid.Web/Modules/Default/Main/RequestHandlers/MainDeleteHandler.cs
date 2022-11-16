using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = NestedGrid.Default.MainRow;

namespace NestedGrid.Default
{
    public interface IMainDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MainDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMainDeleteHandler
    {
        public MainDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}