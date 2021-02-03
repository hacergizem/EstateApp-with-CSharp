using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstateApp.Enums;
using System.Collections.Generic;

namespace EstateApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            ReadAndListTxt();
            ToListView(HomeList);

            tab.TabPages.Remove(summeryTab);
            tab.TabPages.Remove(apartmentTab);
            tab.TabPages.Remove(privateTab);

            homeTypeCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HomeTypeEnum)))
            {
                homeTypeCombobox.Items.Add(name);
            }

            homeStatusCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HomeStatus)))
            {
                homeStatusCombobox.Items.Add(name);
            }

            viewCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HouseView)))
            {
                viewCombobox.Items.Add(name);
            }

            heatingCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(TypeOfHeating)))
            {
                heatingCombobox.Items.Add(name);
            }

            houseListview.Columns.Add("Oda Sayısı", 100);
            houseListview.Columns.Add("Isıtma", 100);
            houseListview.Columns.Add("Ev Tipi", 100);
            houseListview.Columns.Add("Ev Durumu", 100);
            houseListview.Columns.Add("İlan No", 100);
            houseListview.Columns.Add("Fiyat", 117);

        }

        public static List<Home> HomeList = new List<Home>();

        private void IntKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private int HomeID()
        {
            int id = 1;
            if (HomeList.Count > 0)
                id = HomeList.Select(p => p.HomeAdvert).Max() + 1;
            return id;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (roomTextbox.Text =="" || loungeTextbox.Text =="" || heatingCombobox.Text=="" || homeStatusCombobox.Text =="" || homeTypeCombobox.Text=="" || priceTextbox.Text=="")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return;
            }

            using (StreamWriter writeHouse = new StreamWriter("house.txt", true, Encoding.UTF8))
            {
                switch (homeTypeCombobox.Text)
                {
                    case "Yazlık":
                        writeHouse.WriteLine(roomTextbox.Text + "|" +
                                     loungeTextbox.Text + "|" +
                                     heatingCombobox.Text + "|" +
                                     homeTypeCombobox.Text + "|" +
                                     homeStatusCombobox.Text + "|" +
                                     HomeID() + "|" +
                                     priceTextbox.Text + "|" +
                                     poolCheck.Checked + "|" +
                                     viewCombobox.Text
                                     );
                        break;
                    case "Müstakil":
                        writeHouse.WriteLine(roomTextbox.Text + "|" +
                                     loungeTextbox.Text + "|" +
                                     heatingCombobox.Text + "|" +
                                     homeTypeCombobox.Text + "|" +
                                     homeStatusCombobox.Text + "|" +
                                     HomeID() + "|" +
                                     priceTextbox.Text + "|" +
                                     garageCheck.Checked + "|" +
                                     gardenCheck.Checked
                                     );
                        break;
                    case "Apartman":
                        writeHouse.WriteLine(roomTextbox.Text + "|" +
                                     loungeTextbox.Text + "|" +
                                     heatingCombobox.Text + "|" +
                                     homeTypeCombobox.Text + "|" +
                                     homeStatusCombobox.Text + "|" +
                                     HomeID() + "|" +
                                     priceTextbox.Text + "|" +
                                     balconyCheck.Checked + "|" +
                                     floorTextbox.Text
                                     );
                        break;
                    default:
                        break;
                }
                writeHouse.Close();
                ReadAndListTxt();
                ToListView(HomeList);
            }
        }

        public void ReadAndListTxt()
        {
            string[] lines = File.ReadAllLines("house.txt");
            HomeList.Clear();


            foreach (string s in lines)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] row = s.Split('|');

                if (row[3] == "Yazlık")
                {
                    SummeryHouse pv = new SummeryHouse(row);
                    HomeList.Add(pv);
                }

                else if (row[3] == "Müstakil")
                {
                    PrivateHouse pv = new PrivateHouse(row);
                    HomeList.Add(pv);
                }

                else
                {
                    ApartmentHouse pv = new ApartmentHouse(row);
                    HomeList.Add(pv);
                }
            }
        }

        public void ToListView(IEnumerable<Home> listHome)
        {
            houseListview.Items.Clear();
            foreach (var s in listHome)
            {
                string[] sArr = new string[] { s.RoomCount, s.HeatingType.ToString(), s.HomeType.ToString(), s.StatusHome.ToString(), s.HomeAdvert.ToString(), s.Price.ToString() };
                ListViewItem listItem = new ListViewItem(sArr);
                houseListview.Items.Add(listItem);
            }

        }

        private void EditHouse(object sender, MouseEventArgs e)
        {
            
            string selectedHome = houseListview.SelectedItems[0].SubItems[4].Text;
            Home editedHome = HomeList.First(p => p.HomeAdvert.ToString() == selectedHome);
            EditScreen editScreen = new EditScreen(editedHome, this);
            editScreen.ShowDialog();
        }

        private void homeTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (homeTypeCombobox.Text == "Yazlık")
            {
                tab.TabPages.Clear();
                tab.TabPages.Insert(0, summeryTab);
                summeryTab.Focus();
            }
            else if (homeTypeCombobox.Text == "Müstakil")
            {
                tab.TabPages.Clear();
                tab.TabPages.Insert(0, privateTab);
                privateTab.Focus();
            }
            else
            {
                tab.TabPages.Clear();
                tab.TabPages.Insert(0, apartmentTab);
                apartmentTab.Focus();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string selectedID = houseListview.SelectedItems[0].SubItems[4].Text;
            Home deletedHome = HomeList.First(p => p.HomeAdvert.ToString() == selectedID);
            HomeList.Remove(deletedHome);
            SaveListToTxt();
            ReadAndListTxt();
            ToListView(HomeList);
        }
        public static void SaveListToTxt()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var s in HomeList)
            {
                switch (s.HomeType)
                {
                    case HomeTypeEnum.Yazlık:
                        sb.AppendLine(s.Room + "|" + s.Lounge + "|" + s.HeatingType + "|" + s.HomeType + "|" + s.StatusHome + "|" + s.HomeAdvert + "|" + s.Price + "|" + (s as SummeryHouse).Pool + "|" + (s as SummeryHouse).View);
                        break;
                    case HomeTypeEnum.Apartman:
                        sb.AppendLine(s.Room + "|" + s.Lounge + "|" + s.HeatingType + "|" + s.HomeType + "|" + s.StatusHome + "|" + s.HomeAdvert + "|" + s.Price + "|" + (s as ApartmentHouse).Balcony + "|" + (s as ApartmentHouse).Floor);
                        break;
                    case HomeTypeEnum.Müstakil:
                        sb.AppendLine(s.Room + "|" + s.Lounge + "|" + s.HeatingType + "|" + s.HomeType + "|" + s.StatusHome + "|" + s.HomeAdvert + "|" + s.Price + "|" + (s as PrivateHouse).Garage + "|" + (s as PrivateHouse).Garden);
                        break;
                    default:
                        break;
                }
            }
            File.WriteAllText("house.txt", sb.ToString());
        }

        private void SearchBox(object sender, EventArgs e)
        {       
            string searchedHome = searchTextbox.Text;
            List<Home> filtered = new List<Home>();
            foreach (var houses in HomeList)
            {
                if (houses.HomeType.ToString().ToLower().Contains(searchedHome))
                {
                    filtered.Add(houses);
                }
                else if (houses.HeatingType.ToString().ToLower().Contains(searchedHome))
                {
                    filtered.Add(houses);
                }
                else if (houses.RoomCount.ToString().ToLower().Contains(searchedHome))
                {
                    filtered.Add(houses);
                }
            }
            ToListView(filtered);
        }

    }
}
