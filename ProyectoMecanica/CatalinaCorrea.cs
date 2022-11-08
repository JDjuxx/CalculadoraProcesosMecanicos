using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMecanica
{
    internal class CatalinaCorrea
    {
        private float pot_ent;
        private float vel_ang;
        private float diam_cat;
        private float pos_cat;
        private float rel_tens;
        private float ang_hor;
        private int orientacion;
        private float torque;
        private float tension;

        public CatalinaCorrea(float pot_ent, float vel_ang,
                           float diam_cat, float pos_cat,
                           float rel_tens, float ang_hor,
                           int orientacion)
        {
            this.pot_ent = pot_ent;
            this.vel_ang = vel_ang;
            this.diam_cat = diam_cat;
            this.pos_cat = pos_cat;
            this.rel_tens = rel_tens;
            this.ang_hor = ang_hor;
            this.orientacion = orientacion;
        }

        public CatalinaCorrea() { }

        public float Pot_ent { get => pot_ent; set => pot_ent = value; }
        public float Vel_ang { get => vel_ang; set => vel_ang = value; }
        public float Diam_cat { get => diam_cat; set => diam_cat = value; }
        public float Pos_cat { get => pos_cat; set => pos_cat = value; }
        public float Rel_tens { get => rel_tens; set => rel_tens = value; }
        public float Ang_hor { get => ang_hor; set => ang_hor = value; }
        public int Orientacion { get => orientacion; set => orientacion = value; }
        public float Torque { get => torque; set => torque = value; }
        public float Tension { get => tension; set => tension = value; }
    }
}
