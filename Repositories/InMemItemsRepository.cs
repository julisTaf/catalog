using System;
using System.Data.Common;
using System.Linq;
using System.Collections.Generic;
using catalog.Entities;

namespace catalog.Repositories
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name="Potion" , Price = 9 , CreatedDate = DateTimeOffset.UtcNow },       
            new Item { Id = Guid.NewGuid(), Name="Iron Sword" , Price = 20 , CreatedDate = DateTimeOffset.UtcNow },       
            new Item { Id = Guid.NewGuid(), Name="Bronze shield" , Price = 18 , CreatedDate = DateTimeOffset.UtcNow },       
        };
 
        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem( Guid Id )
        {
            return items.Where(  item => item.Id == Id ).SingleOrDefault();
        }
    }
}