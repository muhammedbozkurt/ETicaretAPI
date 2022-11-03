using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adı giriniz!")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Lütfen ürün adını 5-150 karakter arasında giriniz!");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen stok bilgisi giriniz!")
                .Must(s => s >= 0)
                    .WithMessage("Lütfen stok miktarını 0'dan büyük giriniz!");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen fiyat bilgisi giriniz!")
                .Must(s => s >= 0)
                    .WithMessage("Lütfen fiyatı 0'dan büyük giriniz!");
            
        }
    }
}
