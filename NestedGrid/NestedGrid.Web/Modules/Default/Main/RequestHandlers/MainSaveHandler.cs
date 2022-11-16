using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<NestedGrid.Default.MainRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = NestedGrid.Default.MainRow;

namespace NestedGrid.Default
{
    public interface IMainSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MainSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMainSaveHandler
    {
        public MainSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}