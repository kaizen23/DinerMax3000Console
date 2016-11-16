using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.DSDinerMax3000TableAdapters;

namespace DinerMax3000.Business
{
    public class Menu
    {
        public Menu(){
            items = new List<MenuItem>();
        }

        public void AddMenuItem(string Title, string Desctription,double Price)
        {
          MenuItem item = new MenuItem();
          item.Title = Title;
          item.Desctription = Desctription;
          item.Price = Price;
          items.Add(item);
        }
        public string Name;
        public List<MenuItem> items;
    }
}
