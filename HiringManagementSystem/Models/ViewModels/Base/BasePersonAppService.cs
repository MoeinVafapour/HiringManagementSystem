using AutoMapper;
using HiringManagementSystem.Models.Services.Abstracts;
using HiringManagementSystem.Models.ViewModels.Abstarct;

namespace HiringManagementSystem.Models.ViewModels.Base
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
