using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Npgsql;
using DataAccess;

namespace HibachiGuru
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly DatabaseHelper databaseHelper;
        public List<MenuItem> menuItems = new List<MenuItem>();

        public MainWindow()
        {
            InitializeComponent();

            // Set your connection string
            string connectionString = "Host=localhost;Username=postgres;Port=5432;Password=animalfries;Database=postgres";

            databaseHelper = new DatabaseHelper(connectionString);

            // Call the method to read data from the database
            List<String> values = databaseHelper.ReadDataFromDatabase();
            if (values != null && values.Any())
            {
                foreach (string value in values)
                {
                    string[] parts = value.Split(';');

                    if (parts.Length >= 3)
                    {
                        MenuItem menuItem = new MenuItem
                        {
                            Guid = Guid.Parse(parts[0]),
                            ItemName = parts[1],
                            Price = Double.Parse(parts[2]),

                        };

                        menuItems.Add(menuItem);
                        menuComboBox01.Items.Add(menuItem);
                        menuComboBox02.Items.Add(menuItem);
                        menuComboBox03.Items.Add(menuItem);
                        menuComboBox04.Items.Add(menuItem);
                        menuComboBox05.Items.Add(menuItem);
                        menuComboBox06.Items.Add(menuItem);
                        menuComboBox07.Items.Add(menuItem);
                        menuComboBox08.Items.Add(menuItem);
                        menuComboBox09.Items.Add(menuItem);
                        menuComboBox10.Items.Add(menuItem);
                        menuComboBox11.Items.Add(menuItem);
                        menuComboBox12.Items.Add(menuItem);
                        menuComboBox13.Items.Add(menuItem);
                        menuComboBox14.Items.Add(menuItem);
                        menuComboBox15.Items.Add(menuItem);
                        menuComboBox16.Items.Add(menuItem);
                        menuComboBox17.Items.Add(menuItem);
                        menuComboBox18.Items.Add(menuItem);
                        menuComboBox19.Items.Add(menuItem);
                        menuComboBox20.Items.Add(menuItem);
                    }
                    else
                    {

                        /*
                        MenuItem menuItem = MenuItem{
                            Guid = Guid.Parse(parts[0])
                        };
                        menuItems.Add(menuItem);
                        menuComboBox.Items.Add(menuItem);
                        */
                    }
                }
            }
        }
        public class MenuItem
        {
            public Guid Guid { get; set; }
            public string ItemName { get; set; }
            public Double Price { get; set; }
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBox comboBox = sender as ComboBox;
            ComboBox comboBox = (ComboBox)sender;

            // extract the index from the ComboBox name
            //int index = int.Parse(comboBox.Name.Substring(comboBox.Name.Length - 1));
            string indexStr = comboBox.Name.Substring(comboBox.Name.Length - 2);
            int index = int.Parse(indexStr);

            //menuItems is a List<MenuItem> that holds data
            MenuItem selectedItem = menuItems[comboBox.SelectedIndex];

            //there is a textblock for each combo box
            TextBlock priceTextBlock = FindName($"priceTextBlock{index:D2}") as TextBlock;

            // update the textBlock with the selected item's price
            if ( priceTextBlock != null )
            {
                priceTextBlock.Text = $"{selectedItem.Price:C2}";
            }

            /*
            if (comboBox.SelectedItem != null)
            {
                // Get the selected MenuItem from the ComboBox
                MenuItem selectedItem = comboBox.SelectedItem as MenuItem;

                // Display the ItemName in the corresponding TextBlock
                TextBlock priceTextBlock = this.FindName($"priceTextBlock{comboBox.Name[^1]}") as TextBlock;
            }
            */

        }
    }
}
