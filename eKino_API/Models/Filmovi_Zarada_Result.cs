//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eKino_API.Models
{
    using System;
    
    public partial class Filmovi_Zarada_Result
    {
        public string Naziv { get; set; }
        public string IzvorniNaziv { get; set; }
        public short GodinaIzdavanja { get; set; }
        public Nullable<int> Broj_prodanih_ulaznica { get; set; }
        public Nullable<decimal> Zarada { get; set; }
    }
}