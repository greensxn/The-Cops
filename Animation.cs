using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ThisIsThePolice_Test {
    public class Animation {

        public class CopBox_Anim {

            public async void ArrivedToPolice(CopBox Cop) {
                for (int i = 0; i < 10; i++, await Task.Delay(1))
                    Cop.Location = new Point(Cop.Location.X, Cop.Location.Y - 2);

                await Task.Delay(70);

                for (int i = 0; i < 5; i++, await Task.Delay(1))
                    Cop.Location = new Point(Cop.Location.X, Cop.Location.Y + 4);
            }

            public async void MouseEvent(CopBox Cop, bool isMouseEnter) {
                for (int i = 1; i <= 4; i++, await Task.Delay(1)) {
                    Cop.Size = new Size(Cop.Size.Width, Cop.Size.Height + ((isMouseEnter) ? i : -i));
                    Cop.Location = new Point(Cop.Location.X, Cop.Location.Y - ((isMouseEnter) ? i : -i));
                }
            }
        }

        public class Form_Anim {

            private List<SellerBox> SellerList;
            private List<StorageItemBox> ItemList;


            public Form_Anim() {
                SellerList = new List<SellerBox>();
                ItemList = new List<StorageItemBox>();
            }

            public async void Answer_Event(Label label, bool IsMouseEnter) {
                label.ForeColor = (IsMouseEnter) ? Color.White : (label.BackColor == Color.FromArgb(18, 18, 18)) ? Color.DarkGray : Color.FromArgb(18, 18, 18);
                for (float i = 0.5f; i <= 1.5f; i += 0.5f, await Task.Delay(1))
                    label.Font = new Font("AlphaSmart 3000", label.Font.Size + ((IsMouseEnter) ? 1 : -1), FontStyle.Bold);
            }

            public async void Item_Click(Control control, StorageItemBox Item) {
                ClearItem(control, Item);
                if (Item == null || Item != null && Item.pnDock.Location.Y != 106 /*|| ItemList.Count > 0 && ItemList[ItemList.Count - 1] == Item*/)
                    return;

                ItemList.Add(Item);

                // --->     HIDE
                for (int i = 1; i <= 20; i++) {
                    Item.pnLeft.Location = new Point(Item.pnLeft.Location.X - i - (i / 4) - (i / 6), 0);
                    Item.pnRight.Location = new Point(Item.pnRight.Location.X + i + (i / 4) + (i / 6), 0);
                }
                Item.pnSure.Location = new Point(0, -32);
                Item.pnLeft.Size = new Size(175, 154);
                Item.pnRight.Size = new Size(175, 154);

                Item.pnDock.Location = new Point(0, 106);
                Item.pnCountItem.Location = new Point(318, 0);

                Item.pnColor1.Location = new Point(5, 5);
                Item.pnColor2.Location = new Point(36, 5);
                Item.pnColor3.Location = new Point(5, 36);
                Item.pnColor4.Location = new Point(36, 36);
                // <---

                Item.pnLeft.Visible = true;
                Item.pnRight.Visible = true;
                Item.pnSure.Visible = true;

                for (int i = 8; i > 0; i--, await Task.Delay(1)) {
                    Item.pnDock.Location = new Point(Item.pnDock.Location.X, Item.pnDock.Location.Y + 6);
                    Item.pnCountItem.Location = new Point(Item.pnCountItem.Location.X, Item.pnCountItem.Location.Y - 4);

                    Item.pnColor1.Location = new Point(Item.pnColor1.Location.X - 8, 5);
                    Item.pnColor2.Location = new Point(Item.pnColor2.Location.X - 8, 5);
                    Item.pnColor3.Location = new Point(Item.pnColor3.Location.X - 8, 36);
                    Item.pnColor4.Location = new Point(Item.pnColor4.Location.X - 8, 36);
                }
                for (int i = 20; i > 0; i--, await Task.Delay(1)) {
                    Item.pnLeft.Location = new Point(Item.pnLeft.Location.X + i + (i / 4) + (i / 6), 0);
                    Item.pnRight.Location = new Point(Item.pnRight.Location.X - i - (i / 4) - (i / 6), 0);
                }
                for (int i = 8; i > 0; i--, await Task.Delay(1)) {
                    Item.pnSure.Location = new Point(Item.pnSure.Location.X, Item.pnSure.Location.Y + 4);
                    Item.pnLeft.Location = new Point(Item.pnLeft.Location.X, Item.pnLeft.Location.Y + 4);
                    Item.pnLeft.Size = new Size(Item.pnLeft.Size.Width, Item.pnLeft.Size.Height - 4);
                    Item.pnRight.Location = new Point(Item.pnRight.Location.X, Item.pnRight.Location.Y + 4);
                    Item.pnRight.Size = new Size(Item.pnRight.Size.Width, Item.pnRight.Size.Height - 4);
                }
                await Task.Delay(500);
                ClearItem(control, ItemList[ItemList.Count - 1]);
            }

            public async void Item_Event(StorageItemBox Item, bool IsMouseEnter) {
                for (int i = 4; i > 0; i--, await Task.Delay(1)) {
                    Item.pbImage.Size = new Size(Item.pbImage.Size.Width + ((IsMouseEnter) ? i * 2 : -i * 2), Item.pbImage.Size.Height + ((IsMouseEnter) ? i * 2 : -i * 2));
                    Item.pbImage.Location = new Point(Item.pbImage.Location.X - ((IsMouseEnter) ? i : -i), Item.pbImage.Location.Y - ((IsMouseEnter) ? i : -i));
                }
            }

            public async Task Cancel_ClickAsync(SellerBox seller) {
                if (seller.pnBuy.Visible) {
                    if (seller.pnBuy.Size.Height != 135)
                        for (int i = 8; i > 0; i--, await Task.Delay(1)) {
                            seller.pnCancel.Location = new Point(seller.pnCancel.Location.X, seller.pnCancel.Location.Y + 3);
                            seller.pnBuy.Size = new Size(seller.pnBuy.Size.Width, seller.pnBuy.Size.Height + 3);
                            seller.pnCell.Size = new Size(seller.pnCell.Size.Width, seller.pnCell.Size.Height + 3);
                        }

                    for (int i = 20; i > 0; i--, await Task.Delay(1)) {
                        seller.pnBuy.Location = new Point(seller.pnBuy.Location.X - i - (i / 2) - (i / 6) - (i / 8), seller.pnBuy.Location.Y);
                        seller.pnCell.Location = new Point(seller.pnCell.Location.X + i + (i / 2) + (i / 6) + (i / 8), seller.pnCell.Location.Y);
                    }
                    seller.pnBuy.Visible = false;
                    seller.pnCell.Visible = false;

                    for (int i = 20; i > 0; i--) {
                        seller.pnBuy.Location = new Point(seller.pnBuy.Location.X + i + (i / 2) + (i / 6) + (i / 8), seller.pnBuy.Location.Y);
                        seller.pnCell.Location = new Point(seller.pnCell.Location.X - i - (i / 2) - (i / 6) - (i / 8), seller.pnCell.Location.Y);
                    }
                }
                seller.pnCancel.Visible = false;
                seller.pnCancel.Location = new Point(0, 135);
            }

            public async void Cancel_Event(Label label, bool IsMouseEnter) {
                label.ForeColor = (IsMouseEnter) ? Color.White : Color.FromArgb(18, 18, 18);
                for (float i = 0.2f; i <= 0.4f; i += 0.2f, await Task.Delay(1))
                    label.Font = new Font("AlphaSmart 3000", label.Font.Size + ((IsMouseEnter) ? i : -i), FontStyle.Regular);
            }

            public async void Seller_MouseClick(SellerBox seller, Control control) {
                if (SellerList.Count > 0 && SellerList[SellerList.Count - 1] == seller)
                    return;

                SellerList.Add(seller);
                ClearSeller(seller, control);

                for (int i = 20; i > 0; i--) {
                    seller.pnBuy.Location = new Point(seller.pnBuy.Location.X - i - (i / 2) - (i / 6) - (i / 8), seller.pnBuy.Location.Y);
                    seller.pnCell.Location = new Point(seller.pnCell.Location.X + i + (i / 2) + (i / 6) + (i / 8), seller.pnCell.Location.Y);
                }
                seller.pnBuy.Size = new Size(350, 135);
                seller.pnCell.Size = new Size(350, 135);
                seller.pnCancel.Location = new Point(0, 135);

                seller.pnBuy.Visible = true;
                seller.pnCell.Visible = true;
                seller.pnCancel.Visible = true;

                for (int i = 20; i > 0; i--, await Task.Delay(1)) {
                    seller.pnBuy.Location = new Point(seller.pnBuy.Location.X + i + (i / 2) + (i / 6) + (i / 8), seller.pnBuy.Location.Y);
                    seller.pnCell.Location = new Point(seller.pnCell.Location.X - i - (i / 2) - (i / 6) - (i / 8), seller.pnCell.Location.Y);
                }

                await Task.Delay(1000);
                if (SellerList.Count == 1) {
                    for (int i = 8; i > 0; i--, await Task.Delay(1)) {
                        SellerList[0].pnCancel.Location = new Point(SellerList[0].pnCancel.Location.X, SellerList[0].pnCancel.Location.Y - 3);
                        SellerList[0].pnBuy.Size = new Size(SellerList[0].pnBuy.Size.Width, SellerList[0].pnBuy.Size.Height - 3);
                        SellerList[0].pnCell.Size = new Size(SellerList[0].pnCell.Size.Width, SellerList[0].pnCell.Size.Height - 3);
                    }
                }
                SellerList.RemoveAt(0);
            }

            public async void Seller_Event(SellerBox seller, bool IsMouseEnter) {
                seller.ForeColor = Color.White;
                for (int i = 0; i < 4; i++, await Task.Delay(1)) {
                    seller.pbImage.Size = new Size(seller.pbImage.Size.Width + ((IsMouseEnter) ? 4 : -4), seller.pbImage.Size.Height + ((IsMouseEnter) ? 4 : -4));
                    seller.pbImage.Location = new Point(seller.pbImage.Location.X + ((IsMouseEnter) ? -2 : 2), seller.pbImage.Location.Y + ((IsMouseEnter) ? -2 : 2));
                }
            }

            public void ClearSeller(SellerBox exception, Control control) {
                foreach (SellerBox ActiveItem in control.Controls.OfType<SellerBox>())
                    if (ActiveItem != exception)
                        Cancel_ClickAsync(ActiveItem);
            }

            public async Task ClearSellerAsync(SellerBox exception, Control control) {
                foreach (SellerBox ActiveItem in control.Controls.OfType<SellerBox>())
                    if (ActiveItem != exception)
                        await Cancel_ClickAsync(ActiveItem);
            }

            public void ClearItem(Control mainPanelItemBox, StorageItemBox Item) {
                foreach (StorageItemBox ActiveItem in mainPanelItemBox.Controls)
                    if (Item == null && ActiveItem.pnRight.Visible && ActiveItem.pnRight.Location.X == 175 && ActiveItem.pnRight.Location.Y == 32 ||
                        Item as StorageItemBox != ActiveItem && ActiveItem.pnRight.Visible && ActiveItem.pnRight.Location.X == 175 && ActiveItem.pnRight.Location.Y == 32)
                        HideItemAnswerAsync(ActiveItem);
            }

            public async Task HideItemAnswerAsync(StorageItemBox Item) {
                for (int i = 8; i > 0; i--, await Task.Delay(1)) {  // SURE + ANSWERS + CANCEL
                    Item.pnSure.Location = new Point(Item.pnSure.Location.X, Item.pnSure.Location.Y - 4);
                    Item.pnLeft.Location = new Point(Item.pnLeft.Location.X, Item.pnLeft.Location.Y - 4);
                    Item.pnLeft.Size = new Size(Item.pnLeft.Size.Width, Item.pnLeft.Size.Height + 4);
                    Item.pnRight.Location = new Point(Item.pnRight.Location.X, Item.pnRight.Location.Y - 4);
                    Item.pnRight.Size = new Size(Item.pnRight.Size.Width, Item.pnRight.Size.Height + 4);
                }
                for (int i = 20; i > 0; i--, await Task.Delay(1)) {  // ANSWERS
                    Item.pnLeft.Location = new Point(Item.pnLeft.Location.X - i - (i / 4) - (i / 6), 0);
                    Item.pnRight.Location = new Point(Item.pnRight.Location.X + i + (i / 4) + (i / 6), 0);
                }
                Item.pnDock.Location = new Point(0, 154);
                Item.pnCountItem.Location = new Point(318, -32);

                Item.pnColor1.Location = new Point(-59, 5);
                Item.pnColor2.Location = new Point(-28, 5);
                Item.pnColor3.Location = new Point(-59, 36);
                Item.pnColor4.Location = new Point(-28, 36);
                for (int i = 8; i > 0; i--, await Task.Delay(1)) {  // DOCK + COUNT
                    Item.pnDock.Location = new Point(Item.pnDock.Location.X, Item.pnDock.Location.Y - 6);
                    Item.pnCountItem.Location = new Point(Item.pnCountItem.Location.X, Item.pnCountItem.Location.Y + 4);

                    Item.pnColor1.Location = new Point(Item.pnColor1.Location.X + 8, 5);
                    Item.pnColor2.Location = new Point(Item.pnColor2.Location.X + 8, 5);
                    Item.pnColor3.Location = new Point(Item.pnColor3.Location.X + 8, 36);
                    Item.pnColor4.Location = new Point(Item.pnColor4.Location.X + 8, 36);
                }

                // --->    HIDE
                Item.pnLeft.Visible = false;
                Item.pnRight.Visible = false;
                Item.pnSure.Visible = false;

                Item.pnLeft.Location = new Point(0, 0);
                Item.pnLeft.Size = new Size(175, 154);
                Item.pnRight.Location = new Point(175, 0);
                Item.pnRight.Size = new Size(175, 154);

                Item.pnSure.Location = new Point(0, 0);
                // <---
                await Task.Delay(1);
            }

            public async Task StorageFirstAsync(Form form, bool IsShow) {
                for (int i = (IsShow) ? 40 : 1; ((IsShow) ? i > 0 : i <= 40); i = ((IsShow) ? i - 1 : i + 1), await Task.Delay(1))
                    form.Location = new Point(form.Location.X, form.Location.Y + ((IsShow) ? i + (i / 4) : -i - (i / 4)));
            }

            public async Task StorageAsync(Storage_Form form_Storage, bool IsShow) {
                for (int i = 40; i > 0; i--, await Task.Delay(1))
                    form_Storage.Location = new Point(form_Storage.Location.X + ((IsShow) ? -i - (i / 4) : i + (i / 4)), form_Storage.Location.Y);
            }

            public async Task OtherForm(Form form, bool IsShowOrHideRight, bool IsFastStart) {
                for (int i = (IsFastStart) ? 40 : 1; ((IsFastStart) ? i > 0 : i <= 40); i = ((IsFastStart) ? i - 1 : i + 1), await Task.Delay(1))
                    form.Location = new Point(form.Location.X + ((IsShowOrHideRight) ? i + (i / 2) + (i / 2) + (i / 4) : -i - (i / 2) - (i / 2) - (i / 4)), form.Location.Y);
            }
        }

        public class Mission_Anim {

            private static readonly List<NotifyBorder> listMessages = new List<NotifyBorder>();
            private static readonly List<NotifyBorder> listReports = new List<NotifyBorder>();
            private GameMission gameMission;
            private Point point;
            private Panel mainPanel;

            public NotifyBorder NotifyMessage;
            public NotifyBorder NotifyReport;
            public NotifyOnMap MapNotify;


            public Mission_Anim(Panel mainPanel, Point point, GameMission gameMission) {
                this.gameMission = gameMission;
                this.point = point;
                this.mainPanel = mainPanel;
            }

            public Mission_Anim() { }

            public void NewMission() {
                NotifyNew();
                NotifyOnMapNew();
            }

            public async Task NotifyAdd(NotifyBorder Notify, bool isMessage) {
                List<NotifyBorder> ListNotify = (isMessage) ? listMessages : listReports;
                ListNotify.Insert(0, Notify);

                foreach (NotifyBorder list in ListNotify)
                    if (list != Notify)
                        NotifyDownOrUp(list, true);

                Notify.IsMouseEnter += (sender, e) => {
                    Notify_Event((NotifyBorder)sender, isMessage, true);
                    NotifyOnMap_Event(MapNotify, true, 10);
                };
                Notify.IsMouseLeave += (sender, e) => {
                    Notify_Event((NotifyBorder)sender, isMessage, false);
                    NotifyOnMap_Event(MapNotify, false, 10);
                };

                for (int i = 20; i >= 0; i--, await Task.Delay(1))
                    Notify.Location = new Point(Notify.Location.X + ((isMessage) ? i + (i / 4) + (i / 6) : -i - (i / 4) - (i / 6)), Notify.Location.Y);
                await Task.Delay(60);
                for (int i = 1; i <= 6; i++, await Task.Delay(1))
                    Notify.Location = new Point(Notify.Location.X + ((isMessage) ? -i : i), Notify.Location.Y);

                Notify.Location = new Point(Notify.Location.X + ((isMessage) ? -4 : 4), Notify.Location.Y);
                await Task.Delay(5);
                Notify.Location = new Point(Notify.Location.X + ((isMessage) ? -3 : 3), Notify.Location.Y);
                await Task.Delay(8);
                Notify.Location = new Point(Notify.Location.X + ((isMessage) ? -2 : 2), Notify.Location.Y);
                await Task.Delay(10);
                Notify.Location = new Point(Notify.Location.X + ((isMessage) ? -1 : 1), Notify.Location.Y);
            }

            public async void Notify_Event(NotifyBorder Notify, bool isMessage, bool isMouseEnter) {
                for (int i = 6; i > 0; i--, await Task.Delay(1)) {
                    if (!isMessage && i != 3)
                        Notify.Location = new Point(Notify.Location.X - ((isMouseEnter) ? i : -i), Notify.Location.Y);
                    Notify.Size = new Size(Notify.Size.Width + ((isMouseEnter) ? i : -i), 111);
                }
            }

            public async Task NotifyOnMapShowAsync_Event(NotifyOnMap Notify) {
                for (int i = 0; i < 50; i++, await Task.Delay(1)) {
                    if (i % 2 == 0)
                        Notify.Location = new Point(Notify.Location.X - 1, Notify.Location.Y - 1);
                    Notify.Size = new Size(Notify.Size.Width + 1, Notify.Size.Height + 1);
                }
            }

            public async void NotifyOnMap_Event(NotifyOnMap Notify, bool isMouseEnter, int Speed) {
                for (int i = 0; i < Speed; i++, await Task.Delay(1)) {
                    if (i % 2 == 0)
                        Notify.Location = new Point(Notify.Location.X - ((isMouseEnter) ? 1 : -1), Notify.Location.Y - ((isMouseEnter) ? 1 : -1));
                    Notify.Size = new Size(Notify.Size.Width + ((isMouseEnter) ? 1 : -1), Notify.Size.Height + ((isMouseEnter) ? 1 : -1));
                }
            }

            public async void NotifyDelete(NotifyBorder Notify, bool isMessage) {
                await NotifyRemove(Notify, isMessage);
                mainPanel.Controls.Remove(Notify);
                List<NotifyBorder> ListNotify = (isMessage) ? listMessages : listReports;

                if (ListNotify.Count > 0) {
                    if (ListNotify.Count != 1) {

                        int x = 0;
                        for (int i = 0; i < ListNotify.Count; i++)
                            if (ListNotify[i].Name.Contains(Notify.Name))
                                x = i;

                        for (int i = x; i < ListNotify.Count; i++) {
                            if (x == i)
                                continue;

                            NotifyDownOrUp(ListNotify[i], false);
                        }
                    }
                    ListNotify.Remove(Notify);
                }
            }

            public async void NotifyOnMapDelete(NotifyOnMap Notify) {
                Notify.TimeText = String.Empty;
                await Task.Delay(50);
                for (int i = 0; i < 25; i++, await Task.Delay(1)) {
                    if (i % 2 == 0)
                        Notify.Location = new Point(Notify.Location.X + 2, Notify.Location.Y + 2);
                    Notify.Size = new Size(Notify.Size.Width - 2, Notify.Size.Height - 2);
                }
                mainPanel.Controls.Remove(Notify);
            }

            public async void NotifyDownOrUp(NotifyBorder Notify, bool IsDown) {
                for (int i = 0; i < 17; i++, await Task.Delay(4))
                    Notify.Location = new Point(Notify.Location.X, Notify.Location.Y + ((IsDown) ? 7 : -7));
            }

            public async Task NotifyRemove(NotifyBorder Notify, bool isMessage) {
                Notify.Tag = null;
                for (int i = 0; i < 10; i++, await Task.Delay(1))
                    Notify.Location = new Point(Notify.Location.X - ((isMessage) ? 27 : -27), Notify.Location.Y);
            }

            private async void NotifyOnMapNew() {
                MapNotify = new NotifyOnMap(gameMission, this) {
                    Name = gameMission.Name,
                    TimeText = String.Empty,
                    Size = new Size(0, 0),
                    BackColor = gameMission.Type.GetColor_MT(),
                    ForeColor = (gameMission.Type != GameMission.MissionType.Usual) ? Color.White : Color.Black
                };
                MapNotify.IsMouseEnter += NotifyMap_MouseEnter;
                MapNotify.IsMouseLeave += NotifyMap_MouseLeave;

                mainPanel.Controls.Add(MapNotify);
                MapNotify.Location = point;

                await NotifyOnMapShowAsync_Event(MapNotify);

                if (gameMission.DurationSec != -1) {
                    String Time = String.Empty;
                    int TimeCounter = 0;
                    for (int i = 0; i <= gameMission.DurationSec; i++) {   // pause
                        TimeCounter = gameMission.DurationSec - i;
                        Time = $"0:{((TimeCounter.ToString().Length == 1) ? "0" : "")}{TimeCounter}";

                        if (NotifyMessage.MissionType == GameMission.MissionType.Usual) {
                            if (NotifyMessage.BackColor != NotifyMessage.MissionType.GetColor_MT(2) && TimeCounter < 6) {
                                NotifyMessage.BackColor = NotifyMessage.MissionType.GetColor_MT(2);
                                NotifyMessage.ForeColor = NotifyMessage.BackColor.GetColorLabel_MT();

                                MapNotify.BackColor = NotifyMessage.MissionType.GetColor_MT(2);
                                MapNotify.ForeColor = MapNotify.BackColor.GetColorLabel_MT();
                            }
                            else if (NotifyMessage.BackColor != NotifyMessage.MissionType.GetColor_MT(1) && TimeCounter > 5 && TimeCounter < 10) {
                                NotifyMessage.BackColor = NotifyMessage.MissionType.GetColor_MT(1);
                                NotifyMessage.ForeColor = NotifyMessage.BackColor.GetColorLabel_MT();

                                MapNotify.BackColor = NotifyMessage.MissionType.GetColor_MT(1);
                                MapNotify.ForeColor = MapNotify.BackColor.GetColorLabel_MT();
                            }
                        }

                        MapNotify.TimeText = Time;
                        NotifyMessage.TimerText = Time;

                        for (int j = 0; j < 10; j++, await Task.Delay(100)) // pause
                            if (j != gameMission.DurationSec)
                                while (DataTransfer.GamePause)
                                    await Task.Delay(1);
                    }

                    NotifyOnMapDelete(MapNotify);
                }
            }

            public async void NotifyNew() {
                NotifyMessage = new NotifyBorder() {
                    Name = $"CALL_{gameMission.Name}: {gameMission.Description}",
                    IsCall = true,
                    BackColor = gameMission.Type.GetColor_MT(),
                    ForeColor = gameMission.Type.GetColor_MT().GetColorLabel_MT(),
                    BackgroundImage = gameMission.Type.GetNotifyRes(),
                    Location = new Point(48, 128),
                    MissionType = gameMission.Type,
                    NameText = gameMission.Name,
                    TimerText = $"0:{((gameMission.DurationSec.ToString().Length == 1) ? "0" : "")}{gameMission.DurationSec}",
                    PlaceText = gameMission.Place.Name,
                    GameMission = gameMission,
                    Mission = this
                };
                for (int i = 0; i <= 20; i++)
                    NotifyMessage.Location = new Point(NotifyMessage.Location.X - i - (i / 4) - (i / 6), NotifyMessage.Location.Y);

                NotifyReport = new NotifyBorder() {
                    Name = $"REPORT_{gameMission.Name}: {gameMission.Description}",
                    IsCall = false,
                    NameText = gameMission.Name,
                    BackgroundImage = gameMission.Type.GetReportColor(),
                    GameMission = gameMission,
                    Mission = this
                };

                mainPanel.Controls.Add(NotifyMessage);

                await Task.Delay(400);
                await NotifyAdd(NotifyMessage, true);

                for (int i = 1; i < gameMission.DurationSec + 1; i++)
                    for (int j = 0; j < 10; j++, await Task.Delay(100)) // pause
                        if (j != gameMission.DurationSec)
                            while (DataTransfer.GamePause)
                                await Task.Delay(1);

                await Task.Delay(1200);
                while (DataTransfer.GamePause)
                    await Task.Delay(10);

                if (mainPanel.Controls.Contains(NotifyMessage)) {
                    NotifyDelete(NotifyMessage, true);
                    ShowReport();
                }
            }

            public async void ShowReport() {
                int CountNotify = mainPanel.Controls.OfType<NotifyBorder>().Where(a => !a.IsCall).ToList().Count;
                NotifyReport.Location = new Point(mainPanel.Size.Width - 272, 128);
                for (int i = 0; i <= 20; i++)
                    NotifyReport.Location = new Point(NotifyReport.Location.X + i + (i / 4) + (i / 6), NotifyReport.Location.Y);
                mainPanel.Controls.Add(NotifyReport);

                await Task.Delay(400);
                await NotifyAdd(NotifyReport, false);
            }

            private void NotifyMap_MouseEnter(object sender, EventArgs e) {
                NotifyOnMap_Event(MapNotify, true, 10);
                Notify_Event(NotifyMessage, true, true);
            }

            private void NotifyMap_MouseLeave(object sender, EventArgs e) {
                NotifyOnMap_Event(MapNotify, false, 10);
                Notify_Event(NotifyMessage, true, false);
            }
        }

        public async void ShowControl(Control control, int Count, int x, int y) {
            for (int i = 0; i < Count; i++, await Task.Delay(1))
                control.Location = new Point(control.Location.X + x, control.Location.Y + y);
        }
    }
}
