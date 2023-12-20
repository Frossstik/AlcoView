using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AlcoView.Data.Models;

public partial class Category
{
    public int Id { get; set; }

    [DisplayName("Название")]
    public string? Name { get; set; }

    [DisplayName("Описание")]
    public string Description { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
