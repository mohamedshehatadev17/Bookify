namespace Bookify.Web.Core.ViewModels
{
    public class CreateCategoryViewModel
    {
        [MaxLength(100)]
        public string Name { get; set; } = null!;
    }
}
