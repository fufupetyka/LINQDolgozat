using System;
using System.Collections.Generic;
using System.Text;

namespace Dolgozat
{
    internal class Games
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public DateTime KiadasDatum { get; set; }
        public int AktivJatekosok { get; set; }
        public float Ertekeles { get; set; }

        public override string ToString() =>
            $"\tCím: {Cim}\n" +
            $"\tMűfaj: {Mufaj}\n" +
            $"\tKiadás Dátuma: {KiadasDatum}\n" +
            $"\tAktív játékos szám: {AktivJatekosok}\n" +
            $"\tÉrtékelés: {Ertekeles}";

    }
}
