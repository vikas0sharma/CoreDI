using Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{

    public class LabelRepository : ILabelRepository
    {
        public IEnumerable<string> GetLables()
        {
            return new List<string> { "Work", "Personal", "Angular" };
        }
    }
}
