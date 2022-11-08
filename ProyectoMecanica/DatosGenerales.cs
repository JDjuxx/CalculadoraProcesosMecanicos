using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMecanica
{
    internal class DatosGenerales
    {
        private float long_tot_eje;
        private float pos_sop_a;
        private int tip_sop_a;
        private float pos_sop_b;
        private int tip_sop_b;
        private int prop_mat;
        private int tip_ent_pot;

        public DatosGenerales(float long_tot_eje, float pos_sop_a,
                              int tip_sop_a, float pos_sop_b,
                              int tip_sop_b, int prop_mat, int tip_ent_pot)
        {
            this.long_tot_eje = long_tot_eje;
            this.pos_sop_a = pos_sop_a;
            this.tip_sop_a = tip_sop_a;
            this.pos_sop_b = pos_sop_b;
            this.tip_sop_b = tip_sop_b;
            this.prop_mat = prop_mat;
            this.tip_ent_pot = tip_ent_pot;

        }

        public DatosGenerales() { }

        public float Long_tot_eje { get => long_tot_eje; set => long_tot_eje = value; }
        public float Pos_sop_a { get => pos_sop_a; set => pos_sop_a = value; }
        public int Tip_sop_a { get => tip_sop_a; set => tip_sop_a = value; }
        public float Pos_sop_b { get => pos_sop_b; set => pos_sop_b = value; }
        public int Tip_sop_b { get => tip_sop_b; set => tip_sop_b = value; }
        public int Prop_mat { get => prop_mat; set => prop_mat = value; }
        public int Tip_ent_pot { get => tip_ent_pot; set => tip_ent_pot = value; }
    }
}
