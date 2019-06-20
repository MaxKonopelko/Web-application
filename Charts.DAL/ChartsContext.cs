using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Charts.DAL
{
    public class ChartsContext : DbContext
    {
        public ChartsContext() : base("ChartsContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Transaction>()
            //    .HasRequired(x => x.Instrument)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasRequired(x => x.ParticipantBuy)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasRequired(x => x.ParticipantSell)
                .WithMany()
                .WillCascadeOnDelete(false);
        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }

    public class Instrument
    {
        public int Id { get; set; }
        public string NameСurrency { get; set; }
    }

    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Volume { get; set; }
        public DateTime TimeTransactions { get; set; }

        [ForeignKey(nameof(Instrument))]
        public int InstrumentId { get; set; }
        public Instrument Instrument { get; set; }

        [ForeignKey(nameof(ParticipantBuy))]
        public int ParticipantBuyId { get; set; }
        public Participant ParticipantBuy { get; set; }

        [ForeignKey(nameof(ParticipantSell))]
        public int ParticipantSellId { get; set; }
        public Participant ParticipantSell { get; set; }
    }
}
