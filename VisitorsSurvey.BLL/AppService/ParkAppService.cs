using AutoMapper;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.AppService
{
    public class ParkAppService : IParkAppService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ParkAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<ParkDto> GetList()
        {
            var parks = _mapper.Map<List<ParkDto>>(_unitOfWork.ParkRepository.GetAll());
            return parks;
        }
    }
}
