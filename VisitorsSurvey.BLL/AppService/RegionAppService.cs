using AutoMapper;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.AppService
{
    public class RegionAppService : IRegionAppService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public RegionAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<RegionDto> GetList()
        {
            var regions = _mapper.Map<List<RegionDto>>(_unitOfWork.RegionRepository.GetAll());
            return regions;
        }
    }
}
