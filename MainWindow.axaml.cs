using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private bool saludo = true;
    private string nombre = "";
    private string apellido = "";

    private int edad = 0;

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        nombre = Nombre.Text ?? "";

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Resultado.Text = "Escribe el nombre";
            return;
        }

        apellido = Apellido.Text ?? "";

        if (string.IsNullOrWhiteSpace(apellido))
        {
            Resultado.Text = "Escribe el apellido";
            return; // sale del método: no sigue evaluando
        }

        if (!int.TryParse(Edad.Text, out edad))
        {
            Resultado.Text = "Debes escribir un numero";
            return;
        }

        if (!int.TryParse(Edad.Text, out edad) || edad <= 0)
        {
            Resultado.Text = "La edad debe ser un numero mayor que 0";
            return;
        }

        Resultado.Text = $"¡Hola! Mi nombre es {nombre} {apellido}, tengo {edad} años y estoy aprendiendo a desarrollar interfaces gráficas con C#.";
        saludo = false;
    }

    private void Button_Clean(object? sender, RoutedEventArgs e)
    {
        Nombre.Text = "";
        Apellido.Text = "";
        Edad.Text = "";
        Resultado.Text = "Aquí aparecerá el resultado";
        Nombre.Focus();
    }

    private void Button_Saludo(object? sender, RoutedEventArgs e)
    {
        if(saludo == false)
        {
            Resultado.Text = $"Soy {nombre} {apellido}, tengo {edad} años y estoy estudiando en la americana";
            saludo = true;
        }
        else
        {
            Resultado.Text = $"¡Hola! Mi nombre es {nombre} {apellido}, tengo {edad} años y estoy aprendiendo a desarrollar interfaces gráficas con C#.";
            saludo = false;
        }
    }
}