using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<NestedGrid.Default.ChildBRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = NestedGrid.Default.ChildBRow;

namespace NestedGrid.Default
{
    public interface IChildBSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ChildBSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IChildBSaveHandler
    {
        public ChildBSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}