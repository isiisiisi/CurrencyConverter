using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CurrencyConverterApp
{
    public partial class MainForm : Form
    {
        private const string ApiBaseUrl = "https://v6.exchangerate-api.com/v6/2c96b91753abbcfdfb44105b/latest/";
        private bool isSwapping = false;
        private bool isInvalidInput = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeCurrencies();

            FromConvertText.KeyPress += FromConvertText_KeyPress;
            ToConvertText.KeyPress += ToConvertText_KeyPress;

            RefreshBtn.Click += RefreshBtn_Click;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox1.Click += pictureBox1_Click;

            
            _ = UpdateConversionRate();
        }

        private void InitializeCurrencies()
        {
            
            List<string> currencies = new List<string> { "USD", "EUR", "GBP", "JPY", "CAD", "AUD", "PHP" };
            FromCurrency.DataSource = new List<string>(currencies);
            ToCurrency.DataSource = new List<string>(currencies);

            FromCurrency.SelectedIndex = 0;
            ToCurrency.SelectedIndex = 1;
        }

        private void FromConvertText_TextChanged(object sender, EventArgs e)
        {
            if (!isSwapping)
            {
                _ = ConvertCurrency();
            }
        }

        private async void ToConvertText_TextChanged(object sender, EventArgs e)
        {
            if (!isSwapping)
            {
                await ConvertCurrency();
            }
        }

        private async void FromCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSwapping)
            {
                await ConvertCurrency();
                await UpdateConversionRate();
            }
        }

        private async void ToCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSwapping)
            {
                await ConvertCurrency();
                await UpdateConversionRate();
            }
        }

        private async void SwapBtn_Click(object sender, EventArgs e)
        {
            await SwapNumbers();
        }

        private async Task SwapNumbers()
        {
            isSwapping = true;

            
            int fromIndex = FromCurrency.SelectedIndex;
            FromCurrency.SelectedIndex = ToCurrency.SelectedIndex;
            ToCurrency.SelectedIndex = fromIndex;

           
            string tempConvertText = FromConvertText.Text;
            FromConvertText.Text = ToConvertText.Text;
            ToConvertText.Text = tempConvertText;

            isSwapping = false;

            
            await UpdateConversionRate();
            await ConvertCurrency();
        }

        private async Task ConvertCurrency()
        {
            if (decimal.TryParse(FromConvertText.Text, out decimal amount))
            {
                string fromCurrency = FromCurrency.SelectedItem.ToString();
                string toCurrency = ToCurrency.SelectedItem.ToString();
                decimal exchangeRate = await GetExchangeRateAsync(fromCurrency, toCurrency);

                decimal convertedAmount = amount * exchangeRate;

                ToConvertText.TextChanged -= ToConvertText_TextChanged;
                ToConvertText.Text = convertedAmount.ToString("0.##");
                ToConvertText.TextChanged += ToConvertText_TextChanged; 

                ConversionRateLbl.Text = $"1 {fromCurrency} = {exchangeRate} {toCurrency}";
                ConversionRateLbl.Visible = true;
            }
            else
            {
                ToConvertText.Text = "";
            }
        }

        private async Task UpdateConversionRate()
        {
            try
            {
                string fromCurrency = FromCurrency.SelectedItem.ToString();
                string toCurrency = ToCurrency.SelectedItem.ToString();
                decimal exchangeRate = await GetExchangeRateAsync(fromCurrency, toCurrency);
                ConversionRateLbl.Text = $"1 {fromCurrency} = {exchangeRate} {toCurrency}";
                ConversionRateLbl.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"{ApiBaseUrl}{fromCurrency}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<JObject>(responseBody);
                        var rates = responseData["conversion_rates"].ToObject<Dictionary<string, decimal>>();
                        if (rates.ContainsKey(toCurrency))
                        {
                            return rates[toCurrency];
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve exchange rate. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving exchange rate: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 1;
        }

        private void FromCurrency_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void FromConvertText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidKeyPress(e.KeyChar, FromConvertText.Text))
            {
                e.Handled = true;
                if (!isInvalidInput) 
                {
                    MessageBox.Show("Only numbers and decimal points are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInvalidInput = true;
                }
            }
            else
            {
                isInvalidInput = false; 
            }
        }

        private void ToConvertText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidKeyPress(e.KeyChar, ToConvertText.Text))
            {
                e.Handled = true;
                if (!isInvalidInput) 
                {
                    MessageBox.Show("Only numbers and decimal points are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInvalidInput = true;
                }
            }
            else
            {
                isInvalidInput = false; 
            }
        }


        private bool IsValidKeyPress(char keyChar, string text)
        {
            
            if (char.IsControl(keyChar))
            {
                return true;
            }

           
            if (char.IsDigit(keyChar))
            {
                return true;
            }

          
            if (keyChar == '.' && !text.Contains("."))
            {
                return true;
            }

            return false;
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            await ConvertCurrency();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
