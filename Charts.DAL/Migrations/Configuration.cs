using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Charts.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Charts.DAL.ChartsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Charts.DAL.ChartsContext context)
        {        
            if (!context.Instruments.Any() && !context.Participants.Any() && !context.Transactions.Any())
            {
                CreateInstrument(context);
                CreateParticipant(context);
                CreateTransaction(context);
            }
            context.SaveChanges();
        }

        private static void CreateInstrument(ChartsContext context)
        {
            context.Instruments.AddRange(new List<Instrument>
            {
                new Instrument
                {
                    Name—urrency = "Dollar"
                },
                new Instrument
                {
                   Name—urrency = "Evro"
                },
                new Instrument
                {
                    Name—urrency = "Uan"
                },
                new Instrument
                {
                    Name—urrency = "Grivna"
                }
            });
            context.SaveChanges();
        }

        private static void CreateParticipant(ChartsContext context)
        {
            context.Participants.AddRange(new List<Participant>
            {
                new Participant
                {
                    Name = "Max"
                },
                new Participant
                {
                   Name = "Tom"
                },
                new Participant
                {
                    Name = "Vasia"
                }
            });
            context.SaveChanges();
        }

        private static void CreateTransaction(ChartsContext context)
        {
            context.Transactions.AddRange(new List<Transaction>
            {
                new Transaction
                {
                    Price = 2,
                    Volume = 34,
                    InstrumentId = 1,
                    TimeTransactions = DateTime.UtcNow,
                    ParticipantBuyId = 1,
                    ParticipantSellId = 2
                },
                new Transaction
                {
                    Price = 123,
                    Volume = 55,
                    InstrumentId = 2,
                    TimeTransactions = DateTime.UtcNow,
                    ParticipantBuyId = 2,
                    ParticipantSellId =3

                },
                new Transaction
                {
                    Price = 3334,
                    Volume = 3,
                    InstrumentId = 3,
                    TimeTransactions = DateTime.UtcNow,
                    ParticipantBuyId = 1,
                    ParticipantSellId =3
                }
            });
            context.SaveChanges();
        }
    }
}
