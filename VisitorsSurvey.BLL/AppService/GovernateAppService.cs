using AutoMapper;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.AppService
{
    public class GovernateAppService : IGovernateAppService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GovernateAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<GovernateDto> GetList()
        {
            var governates = _mapper.Map<List<GovernateDto>>(_unitOfWork.GovernateRepository.GetAll());
            return governates;
        }
    }
}
