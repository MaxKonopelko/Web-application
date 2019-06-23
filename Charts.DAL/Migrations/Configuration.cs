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
            CreateInstrument(context);
            CreateParticipant(context);
            CreateTransaction(context);         
            context.SaveChanges();
        }

        private static void CreateInstrument(ChartsContext context)
        {
            if (!context.Instruments.Any())
            {
                context.Instruments.AddRange(new List<Instrument>
                {
                    new Instrument
                    {
                        Name—urrency = "USD"
                    },
                    new Instrument
                    {
                       Name—urrency = "EUR"
                    },
                    new Instrument
                    {
                        Name—urrency = "RUB"
                    },
                    new Instrument
                    {
                        Name—urrency = "CNY"
                    }
                });
            }
        }

        private static void CreateParticipant(ChartsContext context)
        {
            if (!context.Participants.Any())
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
                        Name = "Vladimir"
                    }
                });
            }
        }

        private static void CreateTransaction(ChartsContext context)
        {
            if (!context.Transactions.Any()) {
                context.Transactions.AddRange(new List<Transaction>
                {
                    new Transaction
                    {
                        Price = 23,
                        Volume = 34,
                        InstrumentId = 1,
                        TimeTransactions = new DateTime(2019,12,25,15,33,45),
                        ParticipantBuyId = 1,
                        ParticipantSellId = 2
                    },
                    new Transaction
                    {
                        Price = 123,
                        Volume = 55,
                        InstrumentId = 2,
                        TimeTransactions = new DateTime(2019,12,27,12,13,15),
                        ParticipantBuyId = 2,
                        ParticipantSellId =3

                    },
                    new Transaction
                    {
                        Price = 46,
                        Volume = 20,
                        InstrumentId = 2,
                        TimeTransactions = new DateTime(2019,12,29,16,36,55),
                        ParticipantBuyId = 1,
                        ParticipantSellId =3
                    },
                    new Transaction
                    {
                        Price = 78,
                        Volume = 33,
                        InstrumentId = 3,
                        TimeTransactions = new DateTime(2019,12,31,12,26,45),
                        ParticipantBuyId = 1,
                        ParticipantSellId =3
                    },
                    new Transaction
                    {
                        Price = 59,
                        Volume = 5,
                        InstrumentId = 3,
                        TimeTransactions = new DateTime(2020,1,5,13,26,45),
                        ParticipantBuyId = 2,
                        ParticipantSellId =3
                    }
                });
            }
        }
    }
}
