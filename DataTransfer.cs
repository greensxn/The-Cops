using System;
using System.Collections.Generic;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ThisIsThePolice_Test.Properties;

namespace ThisIsThePolice_Test {
    class DataTransfer {

        public static bool GamePause { get; set; }
        public static GameCash Money { get; set; }

        public static List<Cop> SelectedCopList = new List<Cop>();
        public static List<Cop> FreeCopList = new List<Cop>();
        public static Dictionary<String, List<Cop>> CopsOnAMissionList = new Dictionary<string, List<Cop>>();

        public static List<Cop> ChosenCopList = new List<Cop>();
        public static List<CopBox> ChosenCopBoxList = new List<CopBox>();

        public static List<StorageItem> StorageItems = new List<StorageItem>();
        public static List<StorageItem> Seller1Items = new List<StorageItem>();
        public static List<StorageItem> Seller2Items = new List<StorageItem>();
        public static List<StorageItem> Seller3Items = new List<StorageItem>();

        public static List<StorageItem> Items = new List<StorageItem>();
        public static List<Cop> Cops;
        public static List<GameMission> Missions;

        public static SoundPlayer BackSound = new SoundPlayer(Resources.song);
    }

    public class GameCash {

        private Label lbMoney;

        private int Money {
            get {
                return int.Parse(lbMoney.Text.Remove(0, 1));
            }
            set {
                lbMoney.Text = $"${value}";
            }
        }

        public int GetCash() {
            return int.Parse(lbMoney.Text.Remove(0, 1));
        }

        public void AddCash(int Money) {
            int MoneyNow = int.Parse(lbMoney.Text.Remove(0, 1));
            lbMoney.Text = $"${MoneyNow + Money}";
        }

        public GameCash(Label lbMoney, int Money) {
            this.lbMoney = lbMoney;
            this.Money = Money;
        }
    };
}
