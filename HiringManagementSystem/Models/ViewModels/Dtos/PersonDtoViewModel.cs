﻿using System;
using System.Collections.Generic;

namespace HiringManagementSystem.Models.ViewModels.Dtos
{
    public class PersonDtoViewModel
    {
        #region [- Props -]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Family { get; set; }
        public long NationalId { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<TagDtoViewModel> Tags { get; set; } 
        #endregion
    }
}
