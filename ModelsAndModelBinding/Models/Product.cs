namespace ModelsAndModelBinding.Models;

/// <summary>
/// Represents an individual product with its properties and behaviors.
/// </summary>
public class Product
{
    /// <summary>
    /// Gets or sets the unique identifier for the product.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the name of the product. The consumer facing name
    /// of the product. May contain alphanumeric characters, spaces,
    /// and special characters. This property is required.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The pre tax sales price the customer pays for the product.
    /// This property is required and must be a non-negative value.
    /// </summary>
    public required double Price { get; set; }

    /// <summary>
    /// The date and time that the product became available for sale.
    /// This property is required and must be a valid date and time.
    /// </summary>
    public required DateTime StartSalesDate { get; set; }
}

