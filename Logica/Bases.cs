using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Logica
{
    public class Bases
    {
        public static void PerzonalizarDataGridView(ref DataGridView listado)
        {
            listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            listado.BackgroundColor = Color.FromArgb(29, 29, 29);
            //desavilitamos el estilo que viene por defecto de VS
            listado.EnableHeadersVisualStyles = false;
            //le quitamos los bordes
            listado.BorderStyle = BorderStyle.None;
            //quitamos los bordes a las celdas
            listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //quitamos los bordes a las columnas
            listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //quitamos el triangulito de seleccion
            listado.RowHeadersVisible = false;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(29, 29, 29);
            cabecera.ForeColor = Color.White;
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            listado.ColumnHeadersDefaultCellStyle = cabecera;
            
        }

        //(KeyPressEventArgs), identificarlo desd euqe lo escriba
        public static object Decimales(TextBox cajaTexto, KeyPressEventArgs e)
        {
            //(KeyChar), identificar que caracter se a presionado, cada tecla
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                //como es un tipo de dato decimal, usamos el punto (.), para los decimales, cambiamos el punto y la coma, le asiganamos, el punto
                //cambiamos la cultura del sistema
                //como hicimos dos condiconales de que sea punto[0] o coma[1], seleccionamos cual va a mandar, en este caso el punto[0]., por eso colocmaos su indice
                //si preciono la coma lo va a transformar en punto
                e.KeyChar = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            //evitaremos que no escirba 12.3.45.6... etc
            //permitires usar la tecla de punto
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                //que permita la tecla de borrar
                e.Handled = false;
                //ahora hacmeos la negacion de un numero entero con el caracter especial (~)
                //si ya existe el punto, ya no tengo por q habilitar la escritura, esto en el (IndexOff)
                //( ~cajaTexto.Text.IndexOf("."))!=0 ), contamos cuantos puntos tenemos ya escritos, si es diferente de cero, es porque ya existe punto
                //y se procede a bloquear la escritura
            }
            else if (e.KeyChar == '.' &&  (~cajaTexto.Text.IndexOf("."))!=0)
            {
                //que no me permita trabajar
                e.Handled = true;
            }
            //si es igual aun puntito, que le permita trabjaar
            else if (e.KeyChar=='.')
            {
                e.Handled = false;
            }
            //si es a una coma, que le pemrita trabjar
            else if (e.KeyChar==',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return null;
        }

        //diseno del DataGridView, solo para eliminar
        public static void PerzonalizarDataGridViewEliminado(ref DataGridView listado)
        {
            //hacemos un buque a los datos
            //( DataGridViewRow ), vamos a reocrrer todas las FILAS(rows), del DataGridView
            foreach (DataGridViewRow item in listado.Rows)
            {
                //modificamos el color del texto
                string estado;
                //inidcmaos el nombre de la columna
                estado = item.Cells["Estado"].Value.ToString();
                if (estado == "ELIMINADO")
                {
                    //( Strikeout ), diseno que tacha el texto
                    item.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    item.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 128);
                }
            }

        }

        // Calculamos las horas, y de tipo long, para poder calcular las horas o las fechas en su totalidad
        public static long DateDiff(DateIntervalo intervalType, DateTime dateOne, DateTime dateTwo)
        {
            switch (intervalType)
            {
                // si el caso se trata de días
                case DateIntervalo.Day:
                case DateIntervalo.DayOfYear:
                    // para calcular la cnatidad d dias que existiecen
                    TimeSpan spanForDays = dateTwo - dateOne;
                    // retorno los valores cuantos en total se han capturado
                    return (long)spanForDays.TotalDays;
                case DateIntervalo.Hour:
                    TimeSpan spanForHours = dateTwo - dateOne;
                    return (long)spanForHours.TotalHours;
                case DateIntervalo.Minute:
                    TimeSpan spanForMinutes = dateTwo - dateOne;
                    return (long)spanForMinutes.TotalMinutes;
                case DateIntervalo.Month:
                    return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);
                case DateIntervalo.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(dateTwo.Month / 3.0);
                    return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;
                case DateIntervalo.Second:
                    TimeSpan spanForSeconds = dateTwo - dateOne;
                    return (long)spanForSeconds.TotalSeconds;
                case DateIntervalo.Weekday:
                    TimeSpan spanForWeekday = dateTwo - dateOne;
                    return (long)(spanForWeekday.TotalDays / 7.0);
                case DateIntervalo.WeekOfYear:
                    DateTime dateOneModified = dateOne;
                    DateTime dateTwoModified = dateTwo;
                    while (dateTwoModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateTwoModified = dateTwoModified.AddDays(-1);
                    }
                    while (dateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateOneModified = dateOneModified.AddDays(-1);
                    }
                    TimeSpan spanForWeekOfYear = dateTwoModified - dateOneModified;
                    return (long)(spanForWeekOfYear.TotalDays / 7.0);
                case DateIntervalo.Year:
                    return dateTwo.Year - dateOne.Year;
                default:
                    return 0;
            }
        }

        public enum DateIntervalo
        {
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            WeekOfYear,
            Year
        }
    }
}
