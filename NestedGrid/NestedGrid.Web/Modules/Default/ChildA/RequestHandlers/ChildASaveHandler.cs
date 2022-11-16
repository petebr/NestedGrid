using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<NestedGrid.Default.ChildARow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = NestedGrid.Default.ChildARow;

namespace NestedGrid.Default
{
    public interface IChildASaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildASaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IChildASaveHandler
    {
        public ChildASaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}