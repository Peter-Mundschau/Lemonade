using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public Inventory()
        {


        }

        public int paperCupsOnHand = 0;
        public int freshLemonsOnHand = 0;
        public int sugarCupsOnHand = 0;
        public int iceOnHand = 0;
        public List<int> OnHandIventory = new List<int>();



        public void StartingInventory()
        {
            OnHandIventory.Add(paperCupsOnHand);
            OnHandIventory.Add(freshLemonsOnHand);
            OnHandIventory.Add(sugarCupsOnHand);
            OnHandIventory.Add(iceOnHand);
        }


        public void AdjustInventoryDown()
        {
            
            
        }



    }
}
