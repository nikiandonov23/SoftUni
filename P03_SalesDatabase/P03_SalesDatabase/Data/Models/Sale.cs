﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_SalesDatabase.Data.Models;

public class Sale
{


    [Key]
    public int SaleId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; } = null!;


    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; } = null!;


    [ForeignKey(nameof(Store))]
    public int StoreId { get; set; }
    public virtual Store Store { get; set; } = null!;







}