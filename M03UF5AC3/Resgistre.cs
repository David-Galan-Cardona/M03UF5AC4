using System;
using CsvHelper.Configuration.Attributes;

namespace M03UF5AC3
{
    public class Registre
    {
        [Index(0)]
        public int Any { get; set; }
        [Index(1)]
        public int Codi_comarca { get; set; }
        [Index(2)]
        public string Comarca { get; set; }
        [Index(3)]
        public int Població { get; set; }
        [Index(4)]
        public int Domèstic_xarxa { get; set; }
        [Index(5)]
        public int Activitats_econòmiques_i_fonts_pròpies { get; set; }
        [Index(6)]
        public int Total { get; set; }
        [Index(7)]
        public double Consum_domèstic_per_càpita { get; set; }

        public override string ToString()
        {
            return $"Any: {Any}, Codi comarca: {Codi_comarca}, Comarca: {Comarca}, Població: {Població}, Domèstic xarxa: {Domèstic_xarxa}, Activitats econòmiques i fonts pròpies: {Activitats_econòmiques_i_fonts_pròpies}, Total: {Total}, Consum domèstic per càpita: {Consum_domèstic_per_càpita}";
        }
    }
}
