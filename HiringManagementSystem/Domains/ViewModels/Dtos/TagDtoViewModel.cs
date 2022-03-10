namespace HiringManagementSystem.Domains.ViewModels.Dtos
{
    public class TagDtoViewModel
    {
        #region [- Props -]
        public int Id { get; set; }
        public string TagName { get; set; }
        public string Description { get; set; }
        public int PersonId { get; set; }
        public PersonDtoViewModel Person { get; set; } 
        #endregion
    }
}
