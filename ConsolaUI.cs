using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    public class ConsolaUI
    {
        private readonly MotorAhorcado _motor;

        public ConsolaUI(MotorAhorcado motor)
        {
            _motor = motor;
        }

        public static string pedirCategoria()
        {
            Console.WriteLine("-- Categorías --");
            Console.WriteLine("1.- POO");
            Console.WriteLine("2.- .NET");
            Console.WriteLine("3.- Arquitectura");
            Console.WriteLine("4.- Random");

          
            Console.Write("\nOpción (1/2/3/4): ");
            return Console.ReadLine();
        }

        public void MostrarTablero()
        {
            Console.Clear();
            MostrarAhorcado();
            Console.WriteLine($"Intentos restantes: {_motor.IntentosRestantes}");
            Console.WriteLine($"Letras usadas: {string.Join(", ", _motor.LetrasUsadas)}");
            Console.Write("Palabra: ");
            foreach (char c in _motor.PalabraSecreta)
                Console.Write(_motor.LetrasUsadas.Contains(c) ? c : '_');
            Console.WriteLine();

            if(_motor.MostrarPista)
                Console.WriteLine($"Pista: La palabra empieza con '{ _motor.PalabraSecreta[0]}'");
        }

        public char PedirLetra()
        {
            Console.Write("\nIngresa una letra: ");
            return Console.ReadLine()[0];
        }

        public void MostrarMensaje(string mensaje) => Console.WriteLine(mensaje);

        public bool PreguntarOtraVez()
        {
            Console.Write("\n¿Jugar otra vez? (s/n): ");
            return Console.ReadLine()?.ToLower() == "s";
        }

        private void MostrarAhorcado()
        {
            string[] etapas = new string[]
            {
                "  ---- \n |    |\n      |\n      |\n      |\n      |\n=========",
                "  ---- \n |    |\n O    |\n      |\n      |\n      |\n=========",
                "  ---- \n |    |\n O    |\n |    |\n      |\n      |\n=========",
                "  ---- \n |    |\n O    |\n/|    |\n      |\n      |\n=========",
                "  ---- \n |    |\n O    |\n/|\\\\  |\n      |\n      |\n=========",
                "  ---- \n |    |\n O    |\n/|\\\\  |\n/     |\n      |\n=========",
                "  ---- \n |    |\n O    |\n/|\\\\  |\n/ \\   |\n      |\n========="
            };
            Console.WriteLine(etapas[6 - _motor.IntentosRestantes]);
        }
    }
}
