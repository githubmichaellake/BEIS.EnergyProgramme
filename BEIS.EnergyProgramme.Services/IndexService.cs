using BEIS.EnergyProgramme.Services.Requests;
using BEIS.EnergyProgramme.Services.Responses;

namespace BEIS.EnergyProgramme.Services
{
    public class IndexService
    {
        public IndexResponseModel Execute(IndexRequestModel model)
        {
            return new IndexResponseModel
            {
                Message = $"hello {model.Name}"                
            };
        }
    }
}
