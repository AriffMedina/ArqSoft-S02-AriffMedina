using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly List<string> _palabrasParaJugar;

        public PalabrasEnMemoria(string opcionCategoria)
        {
            List<string> arquitectura = new() { "arquitectura", "microservicios", "monolito", "patrones" };
            List<string> poo = new() { "polimorfismo", "encapsulamiento", "herencia", "interfaz" };
            List<string> dotnet = new() { "csharp", "blazor", "nuget", "framework" };
            List<string> random = new() { "csharp", "blazor", "nuget", "framework", "polimorfismo", "encapsulamiento", "herencia", "interfaz", "arquitectura", "microservicios", "monolito", "patrones" };


            switch (opcionCategoria)
            {
                case "1":
                    _palabrasParaJugar = poo;
                    break;
                case "2":
                    _palabrasParaJugar = dotnet;
                    break;

                case "3":
                    _palabrasParaJugar = arquitectura;
                    break;

                default:
                    _palabrasParaJugar = random;
                    break;
            }
        }

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            return _palabrasParaJugar[random.Next(_palabrasParaJugar.Count)];
        }
    }
}
