using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMecanica
{
    internal class Engrane
    {
        private float pot_ent;
        private float num_dient_pin;
        private float vel_ang_pin;
        private float num_dient_eng;
        private float pos_eng;
        private float modulo;
        private float diam_pas;
        private int tip_eng;
        private float ang_pres_nor;
        private float ang_pas;
        private float ang_hel;

        private float torque;
        private float vel_ang_eng;
        private float carg_tan;
        private float carg_axi;
        private float carg_rad;

        public Engrane(float pot_ent, float num_dient_pin,
                       float vel_ang_pin, float num_dient_eng,
                       float pos_eng, float modulo, float diam_pas,
                       int tip_eng, float ang_pres_nor, float ang_pas,
                       float ang_hel)
        {
            this.pot_ent = pot_ent;
            this.num_dient_pin = num_dient_pin;
            this.vel_ang_pin = vel_ang_pin;
            this.num_dient_eng = num_dient_eng;
            this.pos_eng = pos_eng;
            this.modulo = modulo;
            this.diam_pas = diam_pas;
            this.tip_eng = tip_eng;
            this.ang_pres_nor = ang_pres_nor;
            this.ang_pas = ang_pas;
            this.ang_hel = ang_hel;
        }

        public Engrane() { }

        public float Pot_ent { get => pot_ent; set => pot_ent = value; }
        public float Num_dient_pin { get => num_dient_pin; set => num_dient_pin = value; }
        public float Vel_ang_pin { get => vel_ang_pin; set => vel_ang_pin = value; }
        public float Num_dient_eng { get => num_dient_eng; set => num_dient_eng = value; }
        public float Pos_eng { get => pos_eng; set => pos_eng = value; }
        public float Modulo { get => modulo; set => modulo = value; }
        public float Diam_pas { get => diam_pas; set => diam_pas = value; }
        public int Tip_eng { get => tip_eng; set => tip_eng = value; }
        public float Ang_pres_nor { get => ang_pres_nor; set => ang_pres_nor = value; }
        public float Ang_pas { get => ang_pas; set => ang_pas = value; }
        public float Ang_hel { get => ang_hel; set => ang_hel = value; }
        public float Torque { get => torque; set => torque = value; }
        public float Vel_ang_eng { get => vel_ang_eng; set => vel_ang_eng = value; }
        public float Carg_tan { get => carg_tan; set => carg_tan = value; }
        public float Carg_axi { get => carg_axi; set => carg_axi = value; }
        public float Carg_rad { get => carg_rad; set => carg_rad = value; }
    }
}
