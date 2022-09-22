using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pg5_semana2.Model;

namespace pg5_semana2.Clases {
    public class cAlumno {
        PG5_SEMANA1Entities db = new PG5_SEMANA1Entities();

        public ALUMNO extraerAlumno(int carne) {
            ALUMNO obj = db.ALUMNOes.Single(x => x.CARNE == carne);
            return obj;
        }

        public List<ALUMNO> mostrarAlumno() {
            return db.ALUMNOes.ToList();
        }

        public ALUMNO borrarAlumno(int carne) {
            
            ALUMNO obj = db.ALUMNOes.Single(x => x.CARNE == carne);
            db.ALUMNOes.Remove(obj);
            db.SaveChanges();
            return obj;
        }

        public void guardarAlumno(int carne, string nombre, int edad, string genero) {
            ALUMNO obj = new ALUMNO();
            obj.CARNE = carne;
            obj.NOMBRE = nombre;
            obj.EDAD = edad;
            obj.GENERO = genero;
            db.ALUMNOes.Add(obj);
            db.SaveChanges();
        }
        
        
    }
}