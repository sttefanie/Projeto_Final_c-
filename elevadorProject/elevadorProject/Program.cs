-using System;
using elevadorProject.Controlller;



namespace elevadorProject
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            var controllerElevador = new ElevadorController();

            controllerElevador.Initial();
        }
    }
}