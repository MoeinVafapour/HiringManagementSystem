using System.Collections.Generic;

namespace HiringManagementSystem.Domains.DomainModels.Aggregates
{
    public class TagAggregate
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public string Description { get; set; }
        public int PersonId { get; set; }
        public PersonAggregate Person { get; set; }
    }
}
