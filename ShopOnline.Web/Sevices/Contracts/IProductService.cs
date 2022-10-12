using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Sevices.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
