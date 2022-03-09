using HiringManagementSystem.Models.ViewModels.Abstarct;

namespace HiringManagementSystem.Models.ViewModels.Base
{
    public class BaseTagAppService : ITagAppService
    {
        public BaseTagAppService(ITagAppService tagService)
        {
            TagService = tagService;
        }

        public ITagAppService TagService { get; set; }
    }
}
