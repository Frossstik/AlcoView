using AlcoView.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AlcoView.Data.Models;

public partial class Product
{
    public int Id { get; set; }

    [DisplayName("Название")]
    public string Name { get; set; } = null!;

    [DisplayName("Страна производитель")]
    public string Country { get; set; } = null!;

    [DisplayName("Изображение")]
    public string ImageUrl { get; set; } = null!;

    [DisplayName("Объем")]
    [Required(ErrorMessage = "Price is required")]
    public decimal Volume { get; set; }

    [DisplayName("Градус")]
    [Required(ErrorMessage = "Price is required")]
    public decimal SpirtVolume { get; set; }

    [DisplayName("Цена")]
    [DisplayFormat(DataFormatString = "{0:C}")]
    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }

    [DisplayName("Количество")]
    public int Count { get; set; }

    [DisplayName("Статус")]
    public CountDescription Status { get; set; }

    [DisplayName("Дата создания")]
    public DateTime Created { get; set; } = DateTime.Now;

    [DisplayName("Категория")]
    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
