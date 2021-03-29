using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisIsThePolice_Test.Properties;

namespace ThisIsThePolice_Test {
    static class Ex {


        public static Cop.CopGender GetGender(this String text) {

            if (text == "Female")
                return Cop.CopGender.Female;
            else
                return Cop.CopGender.Male;

        }

        public static Cop.CopRace GetRace(this String text) {

            if (text == "Asian")
                return Cop.CopRace.Asian;
            else if (text == "Black")
                return Cop.CopRace.Black;
            else return Cop.CopRace.Caucasian;

        }

        public static Image GetImageFromRes(this String text) {

            if (text == "Back_Gangsterrito")
                return Resources.Back_Gangsterrito;
            else if (text == "Back_Hotel")
                return Resources.Back_Hotel;
            else if (text == "Back_VorBrevno")
                return Resources.Back_VorBrevno;
            else if (text == "Back_VorHome")
                return Resources.Back_VorHome;
            else if (text == "Back_SpinnerBoys")
                return Resources.Back_SpinnerBoys;
            else if (text == "Back_Kulinichi")
                return Resources.Back_Kulinichi;
            else if (text == "Back_Kulinichi_2")
                return Resources.Back_Kulinichi_2;
            else if (text == "Back_Kulinichi_3")
                return Resources.Back_Kulinichi_3;
            else if (text == "Back_Kulinichi_4")
                return Resources.Back_Kulinichi_4;

            else if (text == "Dmitry")
                return Resources.Dmitry;
            else if (text == "DmitryB")
                return Resources.DmitryB;
            else if (text == "Nikta2")
                return Resources.Nikta2;
            else if (text == "Jeime")
                return Resources.Jeime;
            else if (text == "Milos")
                return Resources.Milos;
            else if (text == "Kirill")
                return Resources.Kirill;
            else if (text == "Elena")
                return Resources.Elena;
            else if (text == "Bella")
                return Resources.Bella;

            else if (text == "Food")
                return Resources.Storage_Food;
            else if (text == "Gold")
                return Resources.Storage_Gold;
            else if (text == "JBL")
                return Resources.Storage_JBL;
            else if (text == "Katana")
                return Resources.Storage_Katana;
            else if (text == "KraskaC")
                return Resources.Storage_KraskaC;
            else if (text == "KraskaP")
                return Resources.Storage_KraskaP;
            else if (text == "KraskaY")
                return Resources.Storage_KraskaY;
            else if (text == "KraskaR")
                return Resources.Storage_KraskaR;
            else if (text == "Medicine")
                return Resources.Storage_Medicine;
            else if (text == "Perfume")
                return Resources.Storage_Perfume;
            else if (text == "Sigarette")
                return Resources.Storage_Sigarette;
            else if (text == "SpinnerO")
                return Resources.Storage_SpinnerO;
            else if (text == "SpinnerP")
                return Resources.Storage_SpinnerP;
            else if (text == "SpinnerR")
                return Resources.Storage_SpinnerR;
            else if (text == "SpinnerY")
                return Resources.Storage_SpinnerY;
            else if (text == "TV")
                return Resources.Storage_TV;
            else if (text == "Zond")
                return Resources.Storage_Zond;
            else if (text == "Boots")
                return Resources.Storage_Boots;
            else if (text == "Pills")
                return Resources.Storage_Pills;
            else if (text == "Grease")
                return Resources.Storage_Grease;
            else /*if (text == "Vape")*/
                return Resources.Storage_Vape;
        }

        public static Cop.CopPoliticalViews GetPoliticalViews(this String text) {

            if (text == "Democracy")
                return Cop.CopPoliticalViews.Democracy;
            else if (text == "Memonism")
                return Cop.CopPoliticalViews.Memonism;
            else
                return Cop.CopPoliticalViews.Unknown;

        }

        public static GameMission.MissionType GetMissionType(this String text) {

            if (text == "Crime")
                return GameMission.MissionType.Crime;
            else if (text == "Personal")
                return GameMission.MissionType.Personal;
            else return GameMission.MissionType.Usual;

        }

        public static Color GetColor_MT(this GameMission.MissionType MT, int Extreme = 0) {

            if (Extreme == 0) {
                if (MT == GameMission.MissionType.Usual)
                    return Color.Gold;
                else if (MT == GameMission.MissionType.Crime)
                    return Color.Indigo;
                else
                    return Color.MediumVioletRed;
            }
            else if (Extreme == 1)
                return Color.Orange;
            else
                return Color.Maroon;

        }

        public static Color GetColorLabel_MT(this Color color) {

            if (color == Color.Gold || color == Color.Orange)
                return Color.Black;
            else
                return Color.White;

        }

        public static Color GetColorPoliticalViews(this Cop.CopPoliticalViews PV) {

            if (PV == Cop.CopPoliticalViews.Memonism)
                return Color.FromArgb(65, 85, 74);
            else if (PV == Cop.CopPoliticalViews.Democracy)
                return Color.Brown;
            else
                return Color.FromArgb(101, 106, 109);

        }

        public static Image GetNotifyRes(this GameMission.MissionType res) {

            if (res == GameMission.MissionType.Usual)
                return Resources.Notify_City;
            else if (res == GameMission.MissionType.Crime)
                return Resources.Notify_Forest;
            else
                return Resources.Notify_Persons;

        }

        public static Image GetReportColor(this GameMission.MissionType res) {

            if (res == GameMission.MissionType.Usual)
                return Resources.Message_Gold;
            else if (res == GameMission.MissionType.Crime)
                return Resources.Message_Indigo;
            else
                return Resources.Message_Pink;

        }

        public static T GetRandom<T>(this List<T> list) {
            return list[new Random().Next(0, list.Count)];
        }
    }
}
