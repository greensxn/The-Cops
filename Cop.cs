using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsThePolice_Test {
    public class Cop {

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String ID { get; set; }
        public CopGender Gender { get; set; }
        public CopRace Race { get; set; }
        public CopPoliticalViews Views { get; set; }
        public int Professionalism { get; set; }
        public byte RaiseCount { get; set; }
        public int Energy { get; set; }
        public bool IsAlcoholic { get; set; }
        public bool IsWeed { get; set; }
        public bool IsOld { get; set; }
        public bool IsDead {
            get {
                return Controls.IsDead;
            }
            set {
                Controls.IsDead = value;
            }
        }
        public bool IsNeedDead { get; set; }
        public bool IsNeedWeed { get; set; }
        public bool IsNeedOld { get; internal set; }

        public CopBox Controls;
        public Image Photo;

        private static Random r = new Random();


        public Cop(String FirstName, String LastName, Image Photo, CopGender Gender, CopRace Race, CopPoliticalViews Views, int Energy, short Professionalism, byte RaiseCount, bool IsAlcoholic, bool IsOld) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            ID = GenerationCopID();
            this.Photo = Photo;
            this.Gender = Gender;
            this.Race = Race;
            this.Views = Views;
            this.Professionalism = Professionalism;
            this.RaiseCount = RaiseCount;
            this.Energy = Energy;
            this.IsAlcoholic = IsAlcoholic;
            this.IsOld = IsOld;
        }

        public Cop() {
            Controls = new CopBox();
        }

        public String GenerationCopID() {
            String GengeneratedId = "COP";
            String Num = r.Next(1000, 10000).ToString();
            for (int i = 0; i < 4 - Num.Length; i++)
                GengeneratedId += "0";
            return GengeneratedId += Num;
        }

        public enum CopGender {
            Male, Female
        }

        public enum CopRace {
            Black, Caucasian, Asian
        }

        public enum CopPoliticalViews {
            Memonism, Democracy, Unknown
        }

        public void AddProfesionalism(int Num) {
            Professionalism += Num;
            Controls.CopProfesionalism = "★" + Professionalism.ToString();
        }
    }
}
