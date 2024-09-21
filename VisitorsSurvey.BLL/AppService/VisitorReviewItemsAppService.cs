using AutoMapper;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.AppService
{
    public class VisitorReviewItemsAppService : IVisitorReviewItemsAppService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public VisitorReviewItemsAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<VisitorReviewItemDto> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
