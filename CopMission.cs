using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsThePolice_Test {
    public class CopMission {

        public readonly List<Cop> Cops;
        private Cop[] tempCops;
        public readonly GameMission gameMission;
        public event EventHandler<CopMissionArgs> MotionToCrime;
        public event EventHandler<CopMissionArgs> MotionToPolice;
        public event EventHandler<CopMissionArgs> ArrivedToCrime;
        public event EventHandler<CopMissionArgs> ArrivedToPolice;
        public event EventHandler<CopMissionArgs> StartGoToCrime;
        public event EventHandler<CopMissionArgs> StartGoToPolice;
        private bool IsStop;


        public CopMission(List<Cop> Cops, GameMission gameMission) {
            tempCops = Cops.ToArray();
            this.Cops = tempCops.ToList();
            this.gameMission = gameMission;
            IsStop = false;
        }

        private void OnMotionToCrime(object sender, CopMissionArgs e) {
            MotionToCrime?.Invoke(sender, e);
        }

        private void OnMotionToPolice(object sender, CopMissionArgs e) {
            MotionToPolice?.Invoke(sender, e);
        }

        private void OnStartGoToCrime(object sender, CopMissionArgs e) {
            StartGoToCrime?.Invoke(sender, e);
        }

        private void OnStartGoToPolice(object sender, CopMissionArgs e) {
            StartGoToPolice?.Invoke(sender, e);
        }

        private void OnArrivedToCrime(object sender, CopMissionArgs e) {
            ArrivedToCrime?.Invoke(sender, e);
        }

        private void OnArrivedToPolice(object sender, CopMissionArgs e) {
            ArrivedToPolice?.Invoke(sender, e);
        }

        public async void Drive(bool isCrime) {
            IsStop = false;
            ushort.TryParse((gameMission.Place.RoadTime * 100).ToString(), out ushort Sec);

            if (isCrime)
                OnStartGoToCrime(this, new CopMissionArgs(Cops, gameMission));
            else
                OnStartGoToPolice(this, new CopMissionArgs(Cops, gameMission));

            for (ushort i = 1; i <= Sec && !IsStop; i++, await Task.Delay(5)) {

                while (DataTransfer.GamePause)
                    await Task.Delay(10);

                if (isCrime)
                    OnMotionToCrime(this, new CopMissionArgs(Sec, i, Cops, gameMission));
                else
                    OnMotionToPolice(this, new CopMissionArgs(Sec, i, Cops, gameMission));
            }

            if (isCrime)
                OnArrivedToCrime(this, new CopMissionArgs(Cops, gameMission));
            else
                OnArrivedToPolice(this, new CopMissionArgs(Cops, gameMission));

            IsStop = false;
        }

        public void Stop() {
            IsStop = true;
        }
    }

    public class CopMissionArgs {

        public GameMission gameMission;
        public ushort RoadTimeTotal { get; private set; }
        public ushort RoadTimeNow { get; private set; }
        public List<Cop> Cops { get; private set; }

        public CopMissionArgs(ushort RoadTimeTotal, ushort RoadTimeNow, List<Cop> Cops, GameMission gameMission) {
            this.RoadTimeTotal = RoadTimeTotal;
            this.RoadTimeNow = RoadTimeNow;
            this.Cops = Cops;
            this.gameMission = gameMission;
        }

        public CopMissionArgs(List<Cop> Cops, GameMission Mission) {
            this.Cops = Cops;
            this.gameMission = Mission;
            RoadTimeNow = 0;
            RoadTimeTotal = 0;
        }
    }
}
