using FastEndpoints;

using Org.OpenAPITools.Models;
using Order = Org.OpenAPITools.Models.Order;

namespace Org.OpenAPITools.Features;


public class DeleteOrderRequest
{
    /// <summary>
    /// ID of the order that needs to be deleted
    /// </summary>
    public string OrderId { get; set; }
}
public class GetInventoryRequest
{
}
public class GetOrderByIdRequest
{
    /// <summary>
    /// ID of pet that needs to be fetched
    /// </summary>
    public long OrderId { get; set; }
}
public class PlaceOrderRequest
{
    /// <summary>
    /// order placed for purchasing the pet
    /// </summary>
    [FromBody]
    public Order order { get; set; }
}


