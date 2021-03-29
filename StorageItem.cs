using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsThePolice_Test {
    public class StorageItem {

        public Color[] Colors {
            get {
                return Control.ItemColors;
            }
            set {
                Control.ItemColors = value;
            }
        }

        public Image[] Pictures {
            get {
                return Control.ItemPictures;
            }
            set {
                Control.ItemPictures = value;
            }
        }

        public String NameStatic {
            get {
                return Control.ItemNameStatic;
            }
            set {
                Control.ItemNameStatic = value;
            }
        }

        public String Name {
            get {
                return Control.ItemName;
            }
            set {
                Control.ItemName = value;
            }
        }

        public Image Picture {
            get {
                return Control.ItemPicture;
            }
            set {
                Control.ItemPicture = value;
            }
        }

        public int Price {
            get {
                return int.Parse(Control.ItemPrice.Remove(0, 1));
            }
            set {
                Control.ItemPrice = $"${value}";
            }
        }

        public int Count {
            get {
                return Control.ItemCount;
            }
            set {
                Control.ItemCount = value;
            }
        }

        public ItemType Type {
            get {
                return Control.ItemType;
            }
            set {
                Control.ItemType = value;
            }
        }

        public String[] ColorsName {
            get {
                return Control.ItemColorsName;
            }
            set {
                Control.ItemColorsName = value;
            }
        }

        public Color ChosenColor{
            get {
                return Control.ChosenColor;
            }
            set {
                Control.ChosenColor = value;
            }
        }

        public Dictionary<Color, Image> ColorAssociation {
            get {
                return Control.ItemColorAssociation;
            }
            set {
                Control.ItemColorAssociation = value;
            }
        }

        public StorageItemBox Control;

        public StorageItem(String NameStatic, String Name, Image[] Pictures, int Price, int Count, ItemType Type, Color[] Colors, Dictionary<Color, Image> ColorAssociation, String[] ColorsName, Color ChosenColor) {
            Control = new StorageItemBox();
            this.NameStatic = NameStatic;
            this.Name = Name;
            this.Pictures = Pictures;
            this.Picture = Pictures[0];
            this.Price = Price;
            this.Count = Count;
            this.Type = Type;
            this.Colors = Colors;
            this.ChosenColor = ChosenColor;
            Control.ItemColorsName = ColorsName;
            Control.ItemColorAssociation = ColorAssociation;
        }

        public StorageItem(StorageItemBox ItemBox) {
            Control = new StorageItemBox();
            this.NameStatic = ItemBox.ItemNameStatic;
            this.Name = ItemBox.ItemName;
            this.Pictures = ItemBox.ItemPictures;
            this.Picture = ItemBox.ItemPictures[0];
            this.Price = ItemBox.ItemPriceInt;
            this.Count = 1;
            this.Type = ItemBox.ItemType;
            this.Colors = ItemBox.ItemColors;
            this.ChosenColor = ItemBox.ChosenColor;
            this.ColorsName = ItemBox.ItemColorsName;
            this.ColorAssociation = ItemBox.ItemColorAssociation;
        }

        public StorageItem(StorageItem Item) {
            Control = new StorageItemBox();
            this.NameStatic = Item.NameStatic;
            this.Name = Item.Name;
            this.Pictures = Item.Pictures;
            this.Picture = Item.Pictures[0];
            this.Price = Item.Price;
            this.Count = 1;
            this.Type = Item.Type;
            this.Colors = Item.Colors;
            this.ChosenColor = Item.ChosenColor;
            this.ColorsName = Item.ColorsName;
            this.ColorAssociation = Item.ColorAssociation;
        }

        public StorageItem(StorageItem Item, int Count) : this(Item) {
            this.Count = Count;
        }

        public enum ItemType {
            Trash, Legal, Illegal
        }

        //  CREATED BY 
        //  t.me/CMETAHKA
        //  instagram.com/pripa.doc

    }
}
