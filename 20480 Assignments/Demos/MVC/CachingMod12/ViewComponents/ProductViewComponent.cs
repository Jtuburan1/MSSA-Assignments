using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CachingMod12.Repositories;
using CachingMod12.Models;
namespace CachingMod12.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private IProductRepository _repository;

        public ProductViewComponent(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task<IViewComponentResult> InvokeAsync(int id)
        {
            Product product = _repository.GetProduct(id);
            return Task.FromResult<IViewComponentResult>(View("SelectedProduct", product));
        }
    }
}
