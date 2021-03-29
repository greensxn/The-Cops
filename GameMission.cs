using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsThePolice_Test {

    public class GameMission {

        public String Name { get; set; }
        public String Description { get; set; }
        public int CopNeed { get; set; }
        public short Professionalism { get; set; }
        public byte Raise { get; set; }
        public byte Slot { get; set; }
        public bool IsTrueCall { get; set; }
        public int DurationSec { get; set; }
        public MissionType Type { get; set; }
        public bool IsDriveToMisssion { get; set; }
        public bool IsComplete { get; set; }
        public List<int> Answer { get; set; }

        public Image Picture;
        public MissionPlace Place;
        public List<MissionItems> ItemsNeed;
        public List<MissionItems> ItemsGiven;
        public MissionComplications Complications;
        public MissionReport Report;


        public GameMission(String Name, String Description, Image Picture, int CopNeed, short Professionalism, byte Raise, byte Slot, sbyte DurationSec, MissionType Type, MissionComplications Complications, List<MissionItems> ItemsNeed, MissionPlace Place) {
            this.Name = Name;
            this.Description = Description;
            this.Picture = Picture;
            this.CopNeed = CopNeed;
            this.Professionalism = Professionalism;
            this.Raise = Raise;
            this.Slot = Slot;
            this.DurationSec = DurationSec;
            this.Type = Type;
            this.Complications = Complications;
            this.ItemsNeed = ItemsNeed;
            this.Place = Place;
            Answer = new List<int>();
        }

        public GameMission() {
            Answer = new List<int>();
        }

        public GameMission(GameMission GM) {
            Name = GM.Name;
            Description = GM.Description;
            Picture = GM.Picture;
            CopNeed = GM.CopNeed;
            Professionalism = GM.Professionalism;
            Raise = GM.Raise;
            Slot = GM.Slot;
            DurationSec = GM.DurationSec;
            Type = GM.Type;
            Complications = GM.Complications;
            ItemsNeed = GM.ItemsNeed;
            Place = GM.Place;
            Report = GM.Report;
            IsComplete = GM.IsComplete;
            IsDriveToMisssion = GM.IsDriveToMisssion;
            IsTrueCall = GM.IsTrueCall;
            Answer = new List<int>();
        }

        public enum MissionType {
            Crime, Personal, Usual
        }

        public class MissionReport {

            public String[] Answer { get; set; }
            public String AcceptedDescription { get; set; }
            public String NotAcceptedDescription { get; set; }
            public String CompleteResult { get; set; }
            public String NotCompleteResult { get; set; }
            public Image Picture { get; set; }


            public MissionReport(String[] Answer,
                                 String AcceptedDescription, String NotAcceptedDescription,
                                 String CompleteResult, String NotCompleteResult,
                                 Image Picture) {

                this.Answer = Answer;
                this.AcceptedDescription = AcceptedDescription;
                this.NotAcceptedDescription = NotAcceptedDescription;
                this.CompleteResult = CompleteResult;
                this.NotCompleteResult = NotCompleteResult;
                this.Picture = Picture;
            }

            public void SetTag(int AnswerIndex, Cop cop) {
                String CopName = cop.FirstName + " " + cop.LastName;
                Answer[AnswerIndex] = Answer[AnswerIndex].Replace("{COP}", $"{CopName}");
            }

            public void SetTag(Cop cop) {
                String CopName = cop.FirstName + " " + cop.LastName;
                AcceptedDescription = AcceptedDescription.Replace("{COP}", $"{CopName}");
            }
        }

        public class MissionPlace {

            public String Name { get; private set; }
            public ushort RoadTime { get; private set; }


            public MissionPlace(String PlaceName, ushort RoadTime) {
                Name = PlaceName;
                this.RoadTime = RoadTime;
            }
        }

        public class MissionItems {

            public String Name;
            public int Count;


            public MissionItems(String Name, int Count) {
                this.Name = Name;
                this.Count = Count;
            }
        }

        public class MissionComplications {

            public String Name { get; set; }
            public String Description { get; set; }
            public String[] ResponseOptions { get; set; }
            public int[,] CorrectAnswerOptions { get; set; }
            public Image Picture { get; set; }
            public AdditionComplication Addition;

            public MissionComplications(String Name, String Description, String[] ResponseOptions, int[,] CorrectAnswerOptions, Image Picture) {
                this.Name = Name;
                this.Description = Description;
                this.ResponseOptions = ResponseOptions;
                this.CorrectAnswerOptions = CorrectAnswerOptions;
                this.Picture = Picture;
            }

            public MissionComplications() {

            }

            public class AdditionComplication {

                public String[] Descriptions { get; set; }
                public String[] ResponseOptions { get; set; }
                public Image[] Pictures { get; set; }
                public int Answer { get; set; } = -1;

                public AdditionComplication Addition;

                public AdditionComplication() {

                }
            }
        }
    }
}
