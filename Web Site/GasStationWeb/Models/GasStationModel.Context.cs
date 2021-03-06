//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GasStationWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GasStationEntities : DbContext
    {
        public GasStationEntities()
            : base("name=GasStationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ilceler> Ilceler { get; set; }
        public virtual DbSet<Iller> Iller { get; set; }
        public virtual DbSet<archive> archive { get; set; }
        public virtual DbSet<BP> BP { get; set; }
        public virtual DbSet<Opet> Opet { get; set; }
        public virtual DbSet<Shell> Shell { get; set; }
        public virtual DbSet<Total> Total { get; set; }
        public virtual DbSet<turkPetrol> turkPetrol { get; set; }
    
        public virtual int addtest(string il, string ilce)
        {
            var ilParameter = il != null ?
                new ObjectParameter("il", il) :
                new ObjectParameter("il", typeof(string));
    
            var ilceParameter = ilce != null ?
                new ObjectParameter("ilce", ilce) :
                new ObjectParameter("ilce", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addtest", ilParameter, ilceParameter);
        }
    
        public virtual int AddtoBP(string il, string ilce, string benzin, string motorin)
        {
            var ilParameter = il != null ?
                new ObjectParameter("il", il) :
                new ObjectParameter("il", typeof(string));
    
            var ilceParameter = ilce != null ?
                new ObjectParameter("ilce", ilce) :
                new ObjectParameter("ilce", typeof(string));
    
            var benzinParameter = benzin != null ?
                new ObjectParameter("benzin", benzin) :
                new ObjectParameter("benzin", typeof(string));
    
            var motorinParameter = motorin != null ?
                new ObjectParameter("motorin", motorin) :
                new ObjectParameter("motorin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddtoBP", ilParameter, ilceParameter, benzinParameter, motorinParameter);
        }
    
        public virtual int AddtoBPLpg(string il, string otogaz)
        {
            var ilParameter = il != null ?
                new ObjectParameter("il", il) :
                new ObjectParameter("il", typeof(string));
    
            var otogazParameter = otogaz != null ?
                new ObjectParameter("otogaz", otogaz) :
                new ObjectParameter("otogaz", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddtoBPLpg", ilParameter, otogazParameter);
        }
    
        public virtual int AddtoOpet(string il, string ilce, string benzin, string motorin)
        {
            var ilParameter = il != null ?
                new ObjectParameter("il", il) :
                new ObjectParameter("il", typeof(string));
    
            var ilceParameter = ilce != null ?
                new ObjectParameter("ilce", ilce) :
                new ObjectParameter("ilce", typeof(string));
    
            var benzinParameter = benzin != null ?
                new ObjectParameter("benzin", benzin) :
                new ObjectParameter("benzin", typeof(string));
    
            var motorinParameter = motorin != null ?
                new ObjectParameter("motorin", motorin) :
                new ObjectParameter("motorin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddtoOpet", ilParameter, ilceParameter, benzinParameter, motorinParameter);
        }
    
        public virtual int AddtoShell(string il, string ilce, string benzin, string motorin, string otogaz)
        {
            var ilParameter = il != null ?
                new ObjectParameter("il", il) :
                new ObjectParameter("il", typeof(string));
    
            var ilceParameter = ilce != null ?
                new ObjectParameter("ilce", ilce) :
                new ObjectParameter("ilce", typeof(string));
    
            var benzinParameter = benzin != null ?
                new ObjectParameter("benzin", benzin) :
                new ObjectParameter("benzin", typeof(string));
    
            var motorinParameter = motorin != null ?
                new ObjectParameter("motorin", motorin) :
                new ObjectParameter("motorin", typeof(string));
    
            var otogazParameter = otogaz != null ?
                new ObjectParameter("otogaz", otogaz) :
                new ObjectParameter("otogaz", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddtoShell", ilParameter, ilceParameter, benzinParameter, motorinParameter, otogazParameter);
        }
    
        public virtual int AddtoTotal(string il, string ilce, string benzin, string motorin, string otogaz)
        {
            var ilParameter = il != null ?
                new ObjectParameter("il", il) :
                new ObjectParameter("il", typeof(string));
    
            var ilceParameter = ilce != null ?
                new ObjectParameter("ilce", ilce) :
                new ObjectParameter("ilce", typeof(string));
    
            var benzinParameter = benzin != null ?
                new ObjectParameter("benzin", benzin) :
                new ObjectParameter("benzin", typeof(string));
    
            var motorinParameter = motorin != null ?
                new ObjectParameter("motorin", motorin) :
                new ObjectParameter("motorin", typeof(string));
    
            var otogazParameter = otogaz != null ?
                new ObjectParameter("otogaz", otogaz) :
                new ObjectParameter("otogaz", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddtoTotal", ilParameter, ilceParameter, benzinParameter, motorinParameter, otogazParameter);
        }
    
        public virtual int AddtoTurkPetrol(string il, string ilce, string benzin, string motorin, string otogaz)
        {
            var ilParameter = il != null ?
                new ObjectParameter("il", il) :
                new ObjectParameter("il", typeof(string));
    
            var ilceParameter = ilce != null ?
                new ObjectParameter("ilce", ilce) :
                new ObjectParameter("ilce", typeof(string));
    
            var benzinParameter = benzin != null ?
                new ObjectParameter("benzin", benzin) :
                new ObjectParameter("benzin", typeof(string));
    
            var motorinParameter = motorin != null ?
                new ObjectParameter("motorin", motorin) :
                new ObjectParameter("motorin", typeof(string));
    
            var otogazParameter = otogaz != null ?
                new ObjectParameter("otogaz", otogaz) :
                new ObjectParameter("otogaz", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddtoTurkPetrol", ilParameter, ilceParameter, benzinParameter, motorinParameter, otogazParameter);
        }
    
        public virtual ObjectResult<string> getLastDay(string marka)
        {
            var markaParameter = marka != null ?
                new ObjectParameter("marka", marka) :
                new ObjectParameter("marka", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getLastDay", markaParameter);
        }
    
        public virtual int sync_archivedata()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sync_archivedata");
        }
    }
}
