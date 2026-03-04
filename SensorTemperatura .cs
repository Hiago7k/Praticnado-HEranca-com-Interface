namespace Praticnado_HEranca_com_Interface;

internal class SensorTemperatura : ISensor
{


    public bool Ativar() 
    {
        Console.WriteLine("Sensor de temperatura ativado");
        return true;
    }

    public bool Desativar()
    {
        Console.WriteLine("Sensor de temperatura desativado");
        return false;
    }
}
