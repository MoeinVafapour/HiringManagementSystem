using HiringManagementSystem.Domains.ViewModels.Abstarct;

namespace HiringManagementSystem.Domains.ViewModels.Base
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
