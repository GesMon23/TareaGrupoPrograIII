using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;


namespace Proyecto_grupal
{
    class Inventario
    {
        int i = 0;
        string[] lista_productos = new string[7] { "Blusa\t", "Pantalón Mujer", "Vestido\t", "Falda\t", "Playera\t", "Camisa\t", "Pantalón Hombre" };
        int[] codigo_lista = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        double[] stock = new double[7] { 1500, 2000, 1250, 1300, 2000, 1750, 2500 };
        double[] precios = new double[7] { 50, 200, 125, 75, 60, 90, 100 };
        double[] descuentosLun = new double[7] {0.2, 0.17, 0.15,0.13,0.1,0.07,0.05};
        double[] descuentosMar = new double[7] { 0.17, 0.15, 0.13, 0.1, 0.07, 0.05, 0.2 };
        double[] descuentosMier = new double[7] { 0.15, 0.13, 0.1, 0.07, 0.05, 0.2 , 0.17 };
        double[] descuentosJue = new double[7] { 0.13, 0.1, 0.07, 0.05, 0.2, 0.17 , 0.15};
        double[] descuentosVie = new double[7] {  0.1, 0.07, 0.05, 0.2, 0.17, 0.15, 0.13 };
        double[] descuentosSab = new double[7] { 0.07, 0.05, 0.2, 0.17, 0.15, 0.13, 0.1 };
        double[] descuentosDom = new double[7] { 0.05, 0.2, 0.17, 0.15, 0.13, 0.1, 0.07, };
        
        DateTime fecha = new DateTime(2023, 1, 1, 00, 00, 00);

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public string Lista_productos
        {
            get { return lista_productos[i]; }
            set { lista_productos[i] = value; }
        }
        public int Codigo_lista
        {
            get { return codigo_lista[i]; }
            set { codigo_lista[i] = value; }
        }
        public double Stock
        {
            get { return stock[i]; }
            set { stock[i] = value; }
        }
        public double Precio
        {
            get { return precios[i]; }
            set { precios[i] = value; }

        }

        public double DescuentosLun
        {
            get { return descuentosLun[i]; }
            set { descuentosLun[i] = value; }
        }
        public double DescuentosMar
        {
            get { return descuentosMar[i]; }
            set { descuentosMar[i] = value; }
        }
        public double DescuentosMier
        {
            get { return descuentosMier[i]; }
            set { descuentosMier[i] = value; }
        }
        public double DescuentosJue
        {
            get { return descuentosJue[i]; }
            set { descuentosJue[i] = value; }
        }
        public double DescuentosVie
        {
            get { return descuentosVie[i]; }
            set { descuentosVie[i] = value; }
        }
        public double DescuentosSab
        {
            get { return descuentosSab[i]; }
            set { descuentosSab[i] = value; }
        }
        public double DescuentosDom
        {
            get { return descuentosDom[i]; }
            set { descuentosDom[i] = value; }
        }
    }
    class Program
        {
        static void Main(string[] args)
            {
            Inventario inventario1= new Inventario();
                int op;


                do
                {
                    Console.WriteLine("************ BOUTIQUE ELVIS-COCHO **********\n");
                    Console.WriteLine("\t (1) CONSULTAR INVENTARIO PRODUCTOS");
                    Console.WriteLine("\t (2) INGRESO DE COMPRA DE PRODUCTOS ");
                    Console.WriteLine("\t (3) FACTURACION");
                    Console.WriteLine("\t (4) CONSULTAR SISTEMA DE DESCUENTOS");
                    Console.WriteLine("\t (5) SALIR DEL SISTEMA ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("INVENTARIO ACTUAL");
                            Console.WriteLine("ULTIMA ACTUALIZACIÓN: " + inventario1.Fecha);
                            Console.WriteLine("Código\t\tProducto\t\tStock\t\tPrecio");
                            inventario1.I = 0;
                            for (int i = 1; i < 8; i++)
                            {
                                Console.WriteLine(inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" +inventario1.Stock+"\t\tQ"+ inventario1.Precio);
                                inventario1.I = i;
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;


                        case 2:
                            Console.Clear();
                            int cod = 0, anio = 0, mes = 0, dia = 0, hora = 0, min = 0, seg = 0;
                            inventario1.I = 0;
                            double cantidad = 0, stock_in = 0;
                            Console.Clear();
                            Console.WriteLine("INGRESA LA FECHA Y HORA DE INGRESO");
                            Console.WriteLine("YYYY/MM/DD-HH:MM:SS");
                            anio = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("INGRESA LA FECHA Y HORA DE INGRESO");
                            Console.WriteLine("YYYY/MM/DD-HH:MM:SS");
                            Console.Write(anio + "/");
                            mes = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("INGRESA LA FECHA Y HORA DE INGRESO");
                            Console.WriteLine("YYYY/MM/DD-HH:MM:SS");
                            Console.Write(anio + "/" + mes + "/");
                            dia = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("INGRESA LA FECHA Y HORA DE INGRESO");
                            Console.WriteLine("YYYY/MM/DD-HH:MM:SS");
                            Console.Write(anio + "/" + mes + "/" + dia + "-");
                            hora = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("INGRESA LA FECHA Y HORA DE INGRESO");
                            Console.WriteLine("YYYY/MM/DD-HH:MM:SS");
                            Console.Write(anio + "/" + mes + "/" + dia + "-" + hora + ":");
                            min = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("INGRESA LA FECHA Y HORA DE INGRESO");
                            Console.WriteLine("YYYY/MM/DD-HH:MM:SS");
                            Console.Write(anio + "/" + mes + "/" + dia + "-" + hora + ":" + min + ":");
                            seg = int.Parse(Console.ReadLine());
                            DateTime fechaIngr = new DateTime(anio, mes, dia, hora, min, seg);
                            inventario1.Fecha = fechaIngr;
                            Console.WriteLine("Código\t\tProducto\t\tStock");
                            for (int i = 1; i < 8; i++)
                            {
                                Console.WriteLine(inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Stock);
                                inventario1.I = i;
                            }
                            Console.Write("Ingresa el código del producto:  ");
                            cod = int.Parse(Console.ReadLine());
                        if (cod <= 0 || cod > 7)
                        {
                            Console.WriteLine("/ERROR. INGRESA UN VALOR VÁLIDO");
                        }
                        else
                        {
                            inventario1.I = cod - 1;
                            stock_in = inventario1.Stock;
                            Console.Write("Ingresa la cantidad que se compró: ");
                            cantidad = double.Parse(Console.ReadLine());
                            if (cantidad <= 0)
                            {
                                Console.WriteLine("/ERROR. INGRESA UN VALOR VÁLIDO");
                            }
                            inventario1.Stock = stock_in + cantidad;
                        }
                            Console.ReadKey();
                            Console.Clear();
                        break;

                        case 3:
                            Console.Clear();
                            inventario1.I = 0;
                            string nombre = " ", apellidos = " ", nit = "", direc = "", pedido = " ", dia1 = " ", op1 = " ";
                            double desProd = 0, subtotalProd = 0, subtotal = 0, iva = 0, cantidad1 = 0, descTotal = 0, total = 0, caja=0, cambio=0;
                            double[] cuotDesc = new double[7];
                            int codigo = 0;
                            Console.Write("Ingrese su nombre: ");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese sus apellidos: ");
                            apellidos = Console.ReadLine();
                            Console.Write("Ingrese su dirección: ");
                            direc = Console.ReadLine();
                            Console.Write("Ingrese su Nit: ");
                            nit = Console.ReadLine();
                            Console.Write("Ingresa el día de la semana: ");
                            dia1 = Console.ReadLine();
                            inventario1.I = 0;
                            dia1 = dia1.ToLower();
                            if (dia1 == "lunes")
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    inventario1.I = i;
                                    cuotDesc[i] = inventario1.DescuentosLun;
                                }
                            }
                            else if (dia1 == "martes")
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    inventario1.I = i;
                                    cuotDesc[i] = inventario1.DescuentosMar;
                                }
                            }
                            else if (dia1 == "miercoles")
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    inventario1.I = i;
                                    cuotDesc[i] = inventario1.DescuentosMier;
                                }
                            }
                            else if (dia1 == "jueves")
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    inventario1.I = i;
                                    cuotDesc[i] = inventario1.DescuentosJue;
                                }
                            }
                            else if (dia1 == "viernes")
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    inventario1.I = i;
                                    cuotDesc[i] = inventario1.DescuentosVie;
                                }
                            }
                            else if (dia1 == "sabado")
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    inventario1.I = i;
                                    cuotDesc[i] = inventario1.DescuentosSab;
                                }
                            }
                            else if (dia1 == "domingo")
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    inventario1.I = i;
                                    cuotDesc[i] = inventario1.DescuentosDom;
                                }
                            }else
                            {
                            Console.WriteLine("//ERROR INGRESA UN VALOR VÁLIDO");
                            }
                            DateTime fechaVenta = DateTime.Now;
                            inventario1.Fecha = fechaVenta;
                            Console.Clear();
                            do
                            {
                                cantidad1 = 0;
                                subtotalProd = 0;
                                desProd = 0;
                                inventario1.I = 0;
                                Console.WriteLine("Código\t\tProducto\t\tPrecio");
                                for (int i = 1; i < 8; i++)
                                {
                                    Console.WriteLine(inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\tQ" + inventario1.Precio);
                                    inventario1.I = i;
                                }
                                Console.Write("Ingresa el código del producto: ");
                                codigo = int.Parse(Console.ReadLine());
                                inventario1.I = codigo - 1;
                            if (codigo <= 0 || codigo > 7)
                            {
                                Console.WriteLine("/ERROR. INGRESA UN VALOR VÁLIDO");
                            }
                            else
                            {
                                Console.Write("Ingresa la cantidad que deseas comprar: ");
                                cantidad1 = double.Parse(Console.ReadLine());
                                inventario1.Stock -= cantidad1;
                                if (inventario1.Stock <= 0)
                                {
                                    Console.WriteLine("STOCK INSUFICIENTE");
                                }
                                else
                                {
                                    subtotalProd = inventario1.Precio * cantidad1;
                                    desProd = subtotalProd * cuotDesc[codigo - 1];
                                    pedido += inventario1.Codigo_lista + "\t" + inventario1.Lista_productos + "\tQ" + inventario1.Precio + "\t" + cantidad1 + "\t\t%" + (cuotDesc[codigo - 1] * 100) + "\t\t||Q" + subtotalProd + "\t\t||Q" + desProd + "\n";
                                    descTotal += desProd;
                                    subtotal += subtotalProd;
                                    Console.WriteLine("¿Deseas seguir ingresando productos? Si/No");
                                    op1 = Console.ReadLine();
                                    op1 = op1.ToLower();
                                    Console.Clear();
                                }
                            }
                            } while (op1 != "no");
                            total = subtotal - descTotal;
                            iva = (total / 1.12) * 0.12;
                            Console.WriteLine("****************************************FACTURA*****************************************");
                            Console.WriteLine("***********************************BOUTIQUE ELVIS-COCHO*********************************");
                            Console.WriteLine("Nit: " + nit);
                            Console.WriteLine("Nombre del Cliente: " + nombre + " " + apellidos);
                            Console.WriteLine("Dirección: " + direc);
                            Console.WriteLine(dia1.ToUpperInvariant() + "\t" + fechaVenta);  
                            Console.WriteLine("----------------------------------------------------------------------------------------");
                            Console.WriteLine("Codigo\tProducto\tPrecio\tCantidad\tDesc del Día\tSubTotal\tDescuento\n");
                            Console.WriteLine(pedido);
                            Console.WriteLine("----------------------------------------------------------------------------------------");
                            Console.WriteLine("\t\t\t\t\t\t\t\t||Q" + subtotal + "\t\t||Q" + descTotal);
                            Console.WriteLine("----------------------------------------------------------------------------------------\n");
                            Console.WriteLine("Total a pagar:\t\t\t\t\t\t\t\t\t Q" + total);
                            Console.WriteLine("----------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------\n");
                            Console.WriteLine("Iva= Q" + iva);
                            Console.WriteLine("*Todos los precios tienen IVA incluido");
                            Console.WriteLine("----------------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Write("MONTO INRGRESADO: Q");
                            caja=double.Parse(Console.ReadLine());
                            if (caja < total)
                            {
                                Console.WriteLine("MONTO INSUFICIENTE");
                            }
                            else {
                                cambio = caja - total;
                                Console.WriteLine("CAMBIO:  Q" + cambio);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        break;

                        case 4:
                            Console.Clear();
                            string[] diasSem = new string[7] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                            for (int i = 0; i < 7; i++)
                            {
                                inventario1.I = 0;
                                Console.WriteLine("\t\t\t\t" + diasSem[i]);
                                Console.WriteLine("-------------------------------------------------------------------------");
                                Console.WriteLine("|Código\t\tProducto\t\tPrecio\t\tDescuento(%)\t|");
                                Console.WriteLine("-------------------------------------------------------------------------");
                                switch (i)
                                {
                                    case 0:
                                        for (int j = 1; j <= 7; j++)
                                        {
                                            Console.WriteLine("|" + inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Precio + "\t\t%" + (inventario1.DescuentosLun * 100) + "\t\t|");
                                            inventario1.I = j;
                                        }

                                        break;
                                    case 1:
                                        for (int j = 1; j <= 7; j++)
                                        {
                                            Console.WriteLine("|" + inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Precio + "\t\t%" + (inventario1.DescuentosMar * 100) + "\t\t|");
                                            inventario1.I = j;
                                        }
                                        break;
                                    case 2:
                                        for (int j = 1; j < 8; j++)
                                        {
                                            Console.WriteLine("|" + inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Precio + "\t\t%" + (inventario1.DescuentosMier * 100) + "\t\t|");
                                            inventario1.I = j;
                                        }
                                        break;
                                    case 3:
                                        for (int j = 1; j < 8; j++)
                                        {
                                            Console.WriteLine("\t|" + inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Precio + "\t\t%" + (inventario1.DescuentosJue * 100) + "\t|");
                                            inventario1.I = j;
                                        }
                                        break;
                                    case 4:
                                        for (int j = 1; j < 8; j++)
                                        {
                                            Console.WriteLine("|" + inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Precio + "\t\t%" + (inventario1.DescuentosVie * 100) + "\t\t|");
                                            inventario1.I = j;
                                        }
                                        break;
                                    case 5:
                                        for (int j = 1; j < 8; j++)
                                        {
                                            Console.WriteLine("|" + inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Precio + "\t\t%" + (inventario1.DescuentosSab * 100) + "\t\t|");
                                            inventario1.I = j;
                                        }
                                        break;
                                    case 6:
                                        for (int j = 1; j < 8; j++)
                                        {
                                            Console.WriteLine("|" + inventario1.Codigo_lista + "\t\t" + inventario1.Lista_productos + "\t\t" + inventario1.Precio + "\t\t%" + (inventario1.DescuentosDom * 100) + "\t\t|");
                                            inventario1.I = j;
                                        }
                                        break;
                                }
                                Console.WriteLine("-------------------------------------------------------------------------");
                                Console.WriteLine("-------------------------------------------------------------------------\n\n");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA");
                            Console.ReadKey();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("INGRESA UNA OPCION VALIDA\n");
                            break;
                    }
            } while (op != 5);
            }

        }
    }