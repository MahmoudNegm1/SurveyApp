using AutoMapper;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.AppService
{
    public class CityAppService : ICityAppService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CityAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<CityDto> GetList()
        {
            var cities = _mapper.Map<List<CityDto>>(_unitOfWork.CityRepository.GetAll());
            return cities;
        }
    }
}
