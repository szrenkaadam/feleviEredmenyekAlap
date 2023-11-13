﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FeleviEredmenyek
{
    class Tanulo
    {
        private List<string> tantargyak;
        public string TanuloNev { get; set; }
        public string OktatasiAzonosito { get; set; }
        public List<int> Jegyek;


        public Tanulo(string r, List<string> tantargyak)
        {
            string[] s = r.Split("\t");
            TanuloNev = s[0];
            OktatasiAzonosito = s[1];
            Jegyek = new List<int>();
            for (int i = 2; i < s.Length; i++)
            {
                Jegyek.Add(int.Parse(s[i]));
            }
            tantargyak = tantargyak;
        }


        public override string ToString()
        {
            string osztalyzat = $"Tanuló Neve: {TanuloNev}, Oktatási azonosito: {OktatasiAzonosito}, Jegyek:  ";
            for (int i = 0; i < Jegyek.Count; i++)
            {
                osztalyzat += "\n";
                osztalyzat += tantargyak[i] + " " + Jegyek[i];

            }
            return osztalyzat;
        }
    }
}
