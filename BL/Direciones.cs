using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    class Direciones
    {
        public void AgregarDirecciones()
        {
            Direcciones DP = new Direcciones();
            DP.ID_Direcciones = 234;
            DP.ID = 1;
            DP.Pais = "C.R ";
            DP.Provincia = " Heredia";
            DP.Canton ="Central ";
            DP.Distrito = "Ulloa ";
            DP.Detalle = "WWWWWWWWWWW";
            using (QuizDBEntities context = new QuizDBEntities())
            {
                // me agrega ala base datos 
                context.Direcciones.Add(DP);
                context.SaveChanges();// guarda.

            }

        }
    }
}
