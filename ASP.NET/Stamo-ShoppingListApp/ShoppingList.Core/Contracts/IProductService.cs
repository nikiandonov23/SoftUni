﻿using ShoppingList.Core.Dto;

namespace ShoppingList.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();

        Task<ProductViewModel> GetByIdAsync(int id);

        Task AddProductAsync(ProductViewModel model);

        Task UpdateProductAsync(ProductViewModel model);

        Task DeleteProductAsync(int id);
    }
}
