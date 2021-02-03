using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstateApp.Enums;

namespace EstateApp
{
    public partial class EditScreen : Form
    {
        Home editedHome;
        MainPage mainPage;
        public EditScreen(Home home, MainPage mp)
        {
            editedHome = home;
            mainPage = mp;
            InitializeComponent();

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

            heatingCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(TypeOfHeating)))
            {
                heatingCombobox.Items.Add(name);
            }

            viewCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HouseView)))
            {
                viewCombobox.Items.Add(name);
            }

            roomTextbox.Text = home.Room.ToString();
            loungeTextbox.Text = home.Lounge.ToString();
            heatingCombobox.Text = home.HeatingType.ToString();
            homeTypeCombobox.Text = home.HomeType.ToString();
            homeStatusCombobox.Text = home.StatusHome.ToString();
            priceTextbox.Text = home.Price.ToString();

            switch (home.HomeType)
            {
                case HomeTypeEnum.Yazlık:
                    poolCheck.Checked = (home as SummeryHouse).Pool;
                    viewCombobox.Text = (home as SummeryHouse).View.ToString();
                    break;
                case HomeTypeEnum.Apartman:
                    balconyCheck.Checked = (home as ApartmentHouse).Balcony;
                    floorTextbox.Text = (home as ApartmentHouse).Floor.ToString();
                    break;
                case HomeTypeEnum.Müstakil:
                    garageCheck.Checked = (home as PrivateHouse).Garage;
                    gardenCheck.Checked = (home as PrivateHouse).Garden;
                    break;
                default:
                    break;
            }
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (roomTextbox.Text == "" || loungeTextbox.Text == "" || heatingCombobox.Text == "" || homeStatusCombobox.Text == "" || homeTypeCombobox.Text == "" || priceTextbox.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return;
            }

            Home newHome = null;
            switch (homeTypeCombobox.Text)
            {
                case "Yazlık":
                    SummeryHouse newSummary = new SummeryHouse();
                    newSummary.Room = Convert.ToInt32(roomTextbox.Text);
                    newSummary.Lounge = Convert.ToInt32(loungeTextbox.Text);
                    newSummary.HeatingType = (TypeOfHeating)Enum.Parse(typeof(TypeOfHeating), heatingCombobox.Text);
                    newSummary.HomeType = (HomeTypeEnum)Enum.Parse(typeof(HomeTypeEnum), homeTypeCombobox.Text);
                    newSummary.StatusHome = (HomeStatus)Enum.Parse(typeof(HomeStatus), homeStatusCombobox.Text);
                    newSummary.Price = Convert.ToDecimal(priceTextbox.Text);
                    newSummary.Pool = poolCheck.Checked;
                    newSummary.View = (HouseView)Enum.Parse(typeof(HouseView), viewCombobox.Text);
                    newSummary.HomeAdvert = editedHome.HomeAdvert;
                    newHome = newSummary;
                    break;

                case "Müstakil":
                    PrivateHouse newPrivate = new PrivateHouse();
                    newPrivate.Room = Convert.ToInt32(roomTextbox.Text);
                    newPrivate.Lounge = Convert.ToInt32(loungeTextbox.Text);
                    newPrivate.HeatingType = (TypeOfHeating)Enum.Parse(typeof(TypeOfHeating), heatingCombobox.Text);
                    newPrivate.HomeType = (HomeTypeEnum)Enum.Parse(typeof(HomeTypeEnum), homeTypeCombobox.Text);
                    newPrivate.StatusHome = (HomeStatus)Enum.Parse(typeof(HomeStatus), homeStatusCombobox.Text);
                    newPrivate.Price = Convert.ToDecimal(priceTextbox.Text);
                    newPrivate.Garage = garageCheck.Checked;
                    newPrivate.Garden = gardenCheck.Checked;
                    newPrivate.HomeAdvert = editedHome.HomeAdvert;
                    newHome = newPrivate;
                    break;

                case "Apartman":
                    ApartmentHouse newApartment = new ApartmentHouse();
                    newApartment.Room = Convert.ToInt32(roomTextbox.Text);
                    newApartment.Lounge = Convert.ToInt32(loungeTextbox.Text);
                    newApartment.HeatingType = (TypeOfHeating)Enum.Parse(typeof(TypeOfHeating), heatingCombobox.Text);
                    newApartment.HomeType = (HomeTypeEnum)Enum.Parse(typeof(HomeTypeEnum), homeTypeCombobox.Text);
                    newApartment.StatusHome = (HomeStatus)Enum.Parse(typeof(HomeStatus), homeStatusCombobox.Text);
                    newApartment.Price = Convert.ToDecimal(priceTextbox.Text);
                    newApartment.Floor = Convert.ToInt32(floorTextbox.Text);
                    newApartment.Balcony = balconyCheck.Checked;
                    newApartment.HomeAdvert = editedHome.HomeAdvert;
                    newHome = newApartment;
                    break;
                default:
                    break;
            }

            var index = MainPage.HomeList.IndexOf(editedHome);
            MainPage.HomeList.Remove(editedHome);
            MainPage.HomeList.Insert(index, newHome);
            MainPage.SaveListToTxt();
            MessageBox.Show("Başarıyla kaydedildi.","Düzenleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            mainPage.ReadAndListTxt();
            mainPage.ToListView(MainPage.HomeList);
            Close();
        }

        private void IntOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
