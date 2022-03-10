using AutoMapper;
using HiringManagementSystem.Domains.Services.Abstracts;
using HiringManagementSystem.Domains.ViewModels.Abstarct;

namespace HiringManagementSystem.Domains.ViewModels.Base
{
    public class BasePersonAppService : IPersonAppService
    {
        public BasePersonAppService(IPersonRepository personRepository, IMapper mapper)
        {
            PersonRepository = personRepository;
            Mapper = mapper;
        }

        public IPersonRepository PersonRepository { get; }
        public IMapper Mapper { get; }
    }
}
