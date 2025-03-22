using PrimerEjercicio.MisClases;

Vehiculo carro = new Vehiculo(2025, "Roll Royce", "Negro");

Vehiculo carro2 = new Vehiculo(2026, "Ford", "Negro");

carroElectrico miTesla = new carroElectrico(2026, "Gris", "Tesla");

AutoDeCombustion miToyota = new AutoDeCombustion(2025, "Blanco", "Toyota");

Motocicleta mimoto = new Motocicleta(2015, "Beige", "Vespa");

Camion micamion = new Camion(2014, "Blanco", "Ino");

Console.WriteLine("-CARRO ELÉCTRICO");
miTesla.informacionVehiculo();
miTesla.cargarBateria();
miTesla.acelerar(15);
Console.WriteLine("El nivel de bateria es: {0}", miTesla.NivelBateria());
miTesla.apagar();

Console.WriteLine("**********************************");

Console.WriteLine("-CARRO DE COMBUSTIÓN");
miToyota.informacionVehiculo();
miToyota.encender();
miToyota.VerNivelGasolina();
miToyota.acelerar(10);
miToyota.frenar(5);
Console.WriteLine("El nivel de gasolina es: {0}", miToyota.VerNivelGasolina());

Console.WriteLine("**********************************");

Console.WriteLine("-MOTOCICLETA");
mimoto.informacionVehiculo();
mimoto.encender();
mimoto.acelerarmoto(20);
Console.WriteLine("El motor de la moticicleta es de: {0}", mimoto.verTiemposdeMotor());
mimoto.frenar(5);
Console.WriteLine("**********************************");

Console.WriteLine("-Camión");
micamion.informacionVehiculo();
micamion.tipo();
Console.WriteLine("La capacidad de carga es de: {0} toneladas", micamion.verCapacidad());
micamion.cargaActual(10);
micamion.acelerarcamion(22);
micamion.descargar();
micamion.capacidadCarga();
micamion.apagar();