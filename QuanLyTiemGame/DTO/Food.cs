using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemGame.DTO
{
    public class Food
    {
        public Food(int id, string name, int categoryID)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryID = categoryID;
           this.Price = price;
            this.Link_image = link_image;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["ma_uu_dai"].ToString();
            this.CategoryID = (int)row["giam_gia"];
          /*  this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Link_image = row["link_image"].ToString();*/

        }

        private int id;
        private string name;
      private float price;
        private int categoryID;
       private string link_image;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string Link_image { get => link_image; set => link_image = value; }
    }
}
