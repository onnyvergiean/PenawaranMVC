using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Peran_Bagian_MVC
{
    class PenawaranController
    {
        private List<Item> items;

        public PenawaranController()
        {
            items = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.items.Add(item);
        }

        public List<Item> GetItems()
        {
            return this.items;
        }
    }
}
