using System;
using System.Collections;
using System.Collections.Generic;

namespace HiringManagementSystem.Domains.DomainModels.Aggregates
{
    public class PersonAggregate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Family { get; set; }
        public long NationalId { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<TagAggregate> Tags { get; set; }
    }
}
