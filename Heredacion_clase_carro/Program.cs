


using Heredacion_clase_carro;


//HERENCIA CLASE CAMION
camionvolteo Samuelcamion = new camionvolteo("Hino", 2019, "Rojo", 150);
Console.WriteLine($"El camiond de Volteo de Samuel es un {Samuelcamion.Marca}");
Console.WriteLine($" Modelo {Samuelcamion.Modelo}");
Console.WriteLine($" Color {Samuelcamion.Color}\n");

string mensaje;

mensaje = Samuelcamion.EncenderMotor();
Console.WriteLine(mensaje);

for (int i = 0; i < 4; i++)
{
    mensaje = Samuelcamion.acelerar();
    Console.WriteLine(mensaje);
}

for (int i = 0; i < 5; i++)
{
    mensaje = Samuelcamion.Desacelerar();
    Console.WriteLine(mensaje);
}


mensaje = Samuelcamion.deposito();
Console.WriteLine(mensaje);


mensaje = Samuelcamion.regresardepo();
Console.WriteLine(mensaje);







////HERENCIA CLASE CAMIONETA
//Camioneta Samuelcamioneta = new Camioneta("hyundai h100", 2018, "Blanco", 180);
//Console.WriteLine($"La camioneta de Samuel es un {Samuelcamioneta.Marca}");
//Console.WriteLine($" Modelo {Samuelcamioneta.Modelo}");
//Console.WriteLine($" Color {Samuelcamioneta.Color}\n");

//string mensaje;


//for (int i = 0; i < 8; i++)
//{
//    mensaje = Samuelcamioneta.Limitecarga();
//    Console.WriteLine(mensaje);
//}


//mensaje = Samuelcamioneta.EncenderMotor();
//Console.WriteLine(mensaje);

//for (int i = 0; i < 4; i++)
//{
//    mensaje = Samuelcamioneta.acelerar();
//    Console.WriteLine(mensaje);
//}

//for (int i = 0; i < 5; i++)
//{
//    mensaje = Samuelcamioneta.Desacelerar();
//    Console.WriteLine(mensaje);
//}


//for (int i = 0; i < 8; i++)
//{
//    mensaje = Samuelcamioneta.Descarga();
//    Console.WriteLine(mensaje);
//}






////herencia clase Moto
//Moto Samuelmoto = new Moto("Honda V men", 2016, "Negro con franjas", 150);
//Console.WriteLine($"La Moto de Samuel es un {Samuelmoto.Marca}");
//Console.WriteLine($" Modelo {Samuelmoto.Modelo}");
//Console.WriteLine($" Color {Samuelmoto.Color}\n");

//string mensaje;

//mensaje = Samuelmoto.EncenderMotor();
//Console.WriteLine(mensaje);

//for (int i = 0; i < 6; i++)
//{
//    mensaje = Samuelmoto.Cambiovel();
//    Console.WriteLine(mensaje);



//    mensaje = Samuelmoto.acelerar();
//    Console.WriteLine(mensaje);


//}

//Console.WriteLine();

//for (int i = 0; i < 6; i++)
//{
//    mensaje = Samuelmoto.Bajarcambio();
//    Console.WriteLine(mensaje);

//    mensaje = Samuelmoto.Desacelerar();
//    Console.WriteLine(mensaje);

//}

//mensaje = Samuelmoto.luz();
//Console.WriteLine(mensaje);
//mensaje = Samuelmoto.Apagaluz();
//Console.WriteLine(mensaje);










//carro 
//Carro SamuelCarrito = new Carro("Honda Civic", 2022, "Negro", 150);


//Console.WriteLine($"El carro de Samuel es un {SamuelCarrito.Marca}");
//Console.WriteLine($" Modelo {SamuelCarrito.Modelo}");
//Console.WriteLine($" Color {SamuelCarrito.Color}\n");


//Console.WriteLine($"Samuel's model car is {SamuelCarrito.Modelo}");


//ENCENDER EL MOTOR

//string mensaje;
//Console.WriteLine(SamuelCarrito.GetVelocidadActual());
//mensaje = SamuelCarrito.EncenderMotor();
//Console.WriteLine(mensaje);


//for (int i = 0; i < 5; i++)
//{
//    mensaje = SamuelCarrito.acelerar();
//    Console.WriteLine(mensaje);
//}
//for (int i = 0; i < 6; i++)
//{
//    mensaje = SamuelCarrito.Desacelerar();
//    Console.WriteLine(mensaje);

//}


////EL FRENO
////mensaje=SamuelCarrito.Frenado();
////Console.WriteLine(mensaje)


////APAGAR EL MOTOR
//mensaje = SamuelCarrito.ApagarMotor();
//Console.WriteLine(mensaje);

//mensaje = SamuelCarrito.pitar();
//Console.WriteLine(mensaje);

//for (int i = 0; i < 3; i++)
//{

//    mensaje = SamuelCarrito.pitar();
//    Console.WriteLine(mensaje);


//}
