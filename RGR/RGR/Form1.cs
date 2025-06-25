using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace RGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Список об'єктів класу Flight
        List<Flight> flights = new List<Flight>();

        //Обробник для кнопки "Додати рейс"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Flight f = new Flight //Створення екземпляру класу
                {
                    FlightNumber = txtFlightNumber.Text,
                    PlaneName = txtPlaneName.Text,
                    DeparturePoint = txtDeparturePoint.Text,
                    DestinationPoint = txtDestinationPoint.Text,
                    DepartureTime = dtpDepartureTime.Value,
                    ArrivalTime = dtpArrivalTime.Value,
                    TicketPrice = decimal.Parse(txtTicketPrice.Text)
                };

                //Перевірка: час прибуття не раніше часу відправлення
                if (f.ArrivalTime < f.DepartureTime)
                {
                    MessageBox.Show("Час прибуття не може бути раніше часу відправлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                flights.Add(f); //Додаємо екземпляр класу в список
                MessageBox.Show("Рейс додано.");
                ClearFields(); //Очищення полів вводу
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        //Обробник для кнопки "Видалити рейс"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Для видалення потрібно обрати рядок в ListBox
            if (listBoxFlights.SelectedItem is Flight selectedFlight)
            {
                var confirm = MessageBox.Show($"Ви впевнені, що хочете видалити рейс {selectedFlight.FlightNumber}?",
                                              "Підтвердження", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    flights.Remove(selectedFlight);//Видалення зі списку
                    ShowAllFlights();//Оновлення Відображуваного в ListBox 
                    MessageBox.Show("Рейс видалено.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рейс зі списку.");
            }
        }
        //Обробник для кнопки "Показати всі рейси"
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllFlights();
        }
        //Метод для відображення всіх рейсів
        private void ShowAllFlights()
        {
            listBoxFlights.Items.Clear();
            foreach (var flight in flights)
            {
                listBoxFlights.Items.Add(flight); //Додаємо об'єкт
            }
        }
        //Метод для очищення полів вводу
        private void ClearFields()
        {
            txtFlightNumber.Clear();
            txtPlaneName.Clear();
            txtDeparturePoint.Clear();
            txtDestinationPoint.Clear();
            txtTicketPrice.Clear();
        }
        //Обробник для натискання клавіші в полі вводу
        private void txtFlightNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // <Enter> і <Backspace>.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку "Додати рейс"
                    btnAdd.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        //Обробник для натискання клавіші в полі вводу
        private void txtTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtTicketPrice.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку "Додати рейс"
                    btnAdd.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
    }
}
