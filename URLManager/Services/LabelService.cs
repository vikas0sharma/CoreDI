using Contracts.Repository;
using Contracts.Services;
using System.Collections.Generic;

namespace Services
{
    public class LabelService : ILabelService
    {
        private readonly ILabelRepository labelRepository;

        public LabelService(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }
        public IEnumerable<string> GetLables()
        {
            return labelRepository.GetLables();
        }
    }
}
