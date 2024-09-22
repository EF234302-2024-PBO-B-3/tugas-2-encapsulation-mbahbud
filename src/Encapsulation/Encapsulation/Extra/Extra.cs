using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra;

/*
Atribut:

Temperature (double): Suhu yang akan dikonversi.
Unit (string): Satuan suhu yang dimasukkan ("C" untuk Celcius, "F" untuk Fahrenheit, "K" untuk Kelvin).
Properti:

Temperature: Properti untuk menyimpan nilai suhu, dengan validasi agar tidak kurang dari nilai absolut nol (untuk Kelvin, Celcius >= -273.15, Fahrenheit >= -459.67).
Unit: Properti untuk menyimpan satuan suhu dengan validasi string ("C", "F", atau "K").
Metode:

ConvertToCelsius(): Mengonversi suhu ke Celcius.
ConvertToFahrenheit(): Mengonversi suhu ke Fahrenheit.
ConvertToKelvin(): Mengonversi suhu ke Kelvin.
Validasi/Aturan:

Nilai suhu tidak boleh kurang dari batas absolut nol sesuai satuan yang diberikan.
Jika satuan tidak valid, akan diatur ke "C" secara default.
 */

    public class TemperatureConverter
    {
        private double _temperature;
        private string _unit;

        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_unit == "C" && value >= -273.15)
                    _temperature = value;
                else if (_unit == "F" && value >= -459.67)
                    _temperature = value;
                else if (_unit == "K" && value >= 0)
                    _temperature = value;
                else
                    _temperature = _unit == "K" ? 0 : _unit == "F" ? -459.67 : -273.15;
            }
        }

        public string Unit
        {
            get { return _unit; }
            set
            {
                if (value == "C" || value == "F" || value == "K")
                    _unit = value;
                else
                    _unit = "C";
            }
        }

        // Konstruktor
        public TemperatureConverter(double temperature, string unit)
        {
            Unit = unit;      
            Temperature = temperature; 
        }

        // Metode untuk konversi ke Celcius
        public double ConvertToCelsius()
        {
            if (_unit == "F")
                return (Temperature - 32) * 5 / 9;
            else if (_unit == "K")
                return Temperature - 273.15;
            return Temperature;
        }

        // Metode untuk konversi ke Fahrenheit
        public double ConvertToFahrenheit()
        {
            if (_unit == "C")
                return (Temperature * 9 / 5) + 32;
            else if (_unit == "K")
                return (Temperature - 273.15) * 9 / 5 + 32;
            return Temperature;
        }

        // Metode untuk konversi ke Kelvin
        public double ConvertToKelvin()
        {
            if (_unit == "C")
                return Temperature + 273.15;
            else if (_unit == "F")
                return (Temperature - 32) * 5 / 9 + 273.15;
            return Temperature;
        }
    }

