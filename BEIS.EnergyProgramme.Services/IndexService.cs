using BEIS.EnergyProgramme.Services.Requests;
using BEIS.EnergyProgramme.Services.Responses;

namespace BEIS.EnergyProgramme.Services
{
    public class IndexService
    {
        public string DefaultName { get; set; }
        public IndexService(string defaultName)
        {
            DefaultName = defaultName;
        }

        public IndexResponseModel Execute(IndexRequestModel model)
        {
            if (model == null)
            {   
                throw new ArgumentNullException("model");
            }

            var result = DefaultName;

            if (model.Name != "Ben")
            {
                result = $"hello {model.Name}";
            }

            return new IndexResponseModel
            {
                Message = result
            };
        }
    }
}
