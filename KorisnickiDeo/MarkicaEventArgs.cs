using Domen;
using System;

namespace KorisnickiDeo
{
    public class MarkicaEventArgs : EventArgs
    {
        public Markica IzmenjenaMarkica { get; }

        public MarkicaEventArgs(Markica izmenjenaMarkica)
        {
            IzmenjenaMarkica = izmenjenaMarkica;
        }
    }
}