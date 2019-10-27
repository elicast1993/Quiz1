using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BL
{
    public class DatosPersonales
    {
        public void AgregarDatosPersonales()
        {
            Datos_Personales DP = new Datos_Personales();
            DP.ID = 1;
            DP.Nombre = "XXX";
            DP.Apellido = "ZZZ";
            DP.Telefono = "12345678";

            using (QuizDBEntities context = new QuizDBEntities())
            {
                // me agrega ala base datos 
                context.Datos_Personales.Add(DP);
                context.SaveChanges();// guarda.

            }

        }

    }
}
