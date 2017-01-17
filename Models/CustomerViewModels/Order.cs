using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexWebApp.Models.CustomerViewModels
{
    public class Order
  {
      public Order()
    {
      OrderDate = DateTime.Now.Date;
      LineItems = new List<LineItem>();
    }

    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
    

    public Customer Customer { get; set; }

    public ICollection<LineItem> LineItems { get; private set; }
  }
}