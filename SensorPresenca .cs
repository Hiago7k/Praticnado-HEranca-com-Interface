
namespace Praticnado_HEranca_com_Interface;

internal class SensorPresenca : ISensor
{

    public bool Ativar()
    {
        Console.WriteLine("Sensor de presenca Ativado");
        return true;
        
    }

    public bool Desativar()
    {
        Console.WriteLine("Sensor de presenca desativado");
        return false;

    }

}
