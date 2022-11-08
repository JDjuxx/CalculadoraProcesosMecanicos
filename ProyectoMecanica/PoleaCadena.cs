using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMecanica
{
    internal class PoleaCadena
    {
        private float pot_ent;
        private float vel_ang;
        private float diam_pol;
        private float pos_pol;
        private float rel_tens;
        private float ang_hor;
        private int orientacion;
        private float torque;
        private float tension;

        public float Pot_ent { get => pot_ent; set => pot_ent = value; }
        public float Vel_ang { get => vel_ang; set => vel_ang = value; }
        public float Diam_pol { get => diam_pol; set => diam_pol = value; }
        public float Pos_pol { get => pos_pol; set => pos_pol = value; }
        public float Rel_tens { get => rel_tens; set => rel_tens = value; }
        public float Ang_hor { get => ang_hor; set => ang_hor = value; }
        public int Orientacion { get => orientacion; set => orientacion = value; }
        public float Torque { get => torque; set => torque = value; }
        public float Tension { get => tension; set => tension = value; }
    
        public PoleaCadena(float pot_ent, float vel_ang, 
                           float diam_pol, float pos_pol, 
                           float rel_tens, float ang_hor,
                           int orientacion)
        {
            this.pot_ent = pot_ent;
            this.vel_ang = vel_ang;
            this.diam_pol = diam_pol;
            this.pos_pol = pos_pol;
            this.rel_tens = rel_tens;
            this.ang_hor = ang_hor;
            this.orientacion = orientacion;
        }

        public PoleaCadena(){}
        
    }
}
