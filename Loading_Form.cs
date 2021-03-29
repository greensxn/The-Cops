using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class Loading_Form : Form {

        LoadData loadData;

        public Loading_Form() {
            InitializeComponent();
            loadData = new LoadData();
            loadData.LoadStatus += LoadData_LoadStatus;
        }

        private async void LoadingAnimation() {
            await Task.Delay(2400);
            lbLoading.Visible = true;
            lbLoadingStatus.Visible = true;

            while (true) {
                lbLoading.Text = "LOADING";
                await Task.Delay(100);
                lbLoading.Text = "LOADING.";
                await Task.Delay(100);
                lbLoading.Text = "LOADING..";
                await Task.Delay(100);
                lbLoading.Text = "LOADING...";
                await Task.Delay(100);
            }
        }

        private async void Loading_Form_Load(object sender, EventArgs e) {
            LoadingAnimation();

            loadData.FileLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Res/Missions.xls");
            DataTransfer.Missions = await loadData.GetMissions();

            loadData.FileLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Res/Cops.xls");
            DataTransfer.Cops = await loadData.GetCops();

            loadData.FileLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Res/Storage.xls");
            await loadData.GetStorage();

            this.Close();
        }

        private void LoadData_LoadStatus(object sender, string e) {
            lbLoadingStatus.Text = e;
        }
    }
}
