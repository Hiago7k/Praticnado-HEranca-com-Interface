using Praticnado_HEranca_com_Interface;

SensorTemperatura temp = new SensorTemperatura();
SensorPresenca presenca = new SensorPresenca();

temp.Ativar();
temp.Desativar();
Console.WriteLine();
presenca.Ativar();
presenca.Desativar();