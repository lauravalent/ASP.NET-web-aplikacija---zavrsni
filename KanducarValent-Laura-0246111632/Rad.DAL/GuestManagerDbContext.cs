using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rad.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Rad.DAL
{
    public class GuestManagerDbContext : IdentityDbContext<AppUser>
    {
        public GuestManagerDbContext(DbContextOptions<GuestManagerDbContext> options)
        : base(options)
        {
        }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Photo> Photo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Accommodation>()
            //.ToTable("Accomodations");

            //modelBuilder.Entity<Reservation>()
            //.Property(r => r.AccommodationID)
            //.HasColumnName("AccomodationID");

            //modelBuilder.Entity<Review>()
            //    .Property(r => r.AccommodationID)
            //    .HasColumnName("AccomodationID");

            //modelBuilder.Entity<Photo>()
            //.Property(p => p.AccommodationID)
            //.HasColumnName("AccomodationID");

            modelBuilder.Entity<Review>()
            .HasOne(r => r.Reservation)
            .WithMany()
            .HasForeignKey(r => r.ReservationID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Accommodation>()
            .Property(a => a.PricePerNight)
            .HasPrecision(10, 2);

            modelBuilder.Entity<Accommodation>().HasData(
                new Accommodation
                {
                    ID = 1,
                    Name = "Kuća Marijan",
                    Capacity = 2,
                    Size = 30,
                    ImageUrl = "/images/sofija.jpg",
                    PricePerNight = 50.00m,
                    Description = "Kuća Marijan je prostor koji može primiti dvoje ljudi, a nalazi se nedaleko od maslenika i voćnjaka pa je najbolje vrijeme za posjet ljeto i rana jesen." +
                    "Unutrašnjost je inspirirana kućama iz prošlosti koje su prije nekoliko godina na našim prostorima bile bijeg od gradske vreve." +
                    "Osim krova nad glavom, ispred same kuće postoji terasa na kojima se provode tople ljetne večeri uživajući u tišini i ugodnim temperaturama.",                                 
                    PoolDistance = 200,
                    PoolImg = "/images/braco_bazen.png"
                },
                new Accommodation
                {
                    ID = 2,
                    Name = "Kuća Draga",
                    Capacity = 5,
                    Size = 50,
                    ImageUrl = "/images/kuca_draga.jpeg",
                    PricePerNight = 90.00m,
                    Description = "Kuća Draga datira još iz 1929. godine kada je bila kućica u koju su njezini vlasnici dolazili kada su radili u vingoradima. " +
                    "Draga još uvijek ima vinograd odmah pored, no sada u nju dolaze gosti koji žele odmoriti dušu. Osim vinograda, Draga nudi i obilazak podrumom koji " +
                    "se nalazi odmah ispod jedne od soba. Draga ima dvije sobe tako da je pogodna za petero ljudi.",
                   
                    PoolDistance = 150,
                    PoolImg = "/images/draga_bazen.png"
                },
                new Accommodation
                {
                    ID = 3,
                    Name = "Kuća Braco",
                    Capacity = 2,
                    Size = 50,
                    ImageUrl = "/images/braco.jpg",
                    PricePerNight = 70.00m,
                    Description = "Kuća Braco je najmanja kuća na našoj Farmici, no to ne umanjuje njenu vrijednost. Kuća Braco je odlična za mladi bračni par jer je i najbliža bazenu. " +
                    "Odamh pored nalazi se smokva koja je rodna cijelo ljeto. Pošto je najbliža životinjama, dok se odsjeda u Braci, one se najviše čuju tako da " +
                    "će Vas probuditi pijev pijetlova.",                          
                    PoolDistance = 200,
                    PoolImg = "/images/braco_bazen.png"
                },
                new Accommodation
                {
                    ID = 4,
                    Name = "Kuća Laura",
                    Capacity = 4,
                    Size = 56,
                    ImageUrl = "/images/laura.jpg",
                    PricePerNight = 70.00m,
                    Description = "Kuća Laura ima veliki vinograd koji pruža prekrasan pogled i mogućnost uživanja u svježem grožđu tijekom sezone." +
                    "Ima dvije sobe te veliku kupaonu. Kuća Laura je naša prva Kuća kojoj smo dali novi izgled te ju uredili kako bi ugostila svoje goste.",
                    PoolDistance = 400,
                    PoolImg = "/images/laura_bazen.png"
                },
                new Accommodation
                {
                    ID = 5,
                    Name = "Kuća Janko",
                    Capacity = 4,
                    Size = 60,
                    ImageUrl = "/images/marijan.jpeg",
                    PricePerNight = 90.00m,
                    Description = "Kuća Janko ima veliku terasu na kojoj gosti mogu uživati u jutarnjoj kavi ili večernjem opuštanju. " +
                    "Unutrašnjost kuće je prostrana i udobna, s modernim namještajem i svim potrebnim sadržajima za ugodan boravak." +
                    "Prostrana kuhinja omogućava lagano pripremanje obroka, a tijekom jela se može uživati u pogledu na vinograd i šumu.",
                    PoolDistance = 200,
                    PoolImg = "/images/laura_bazen.png"
                }
             
            );

            modelBuilder.Entity<Photo>().HasData(
                new Photo
                {
                    ID = 1,
                    AccommodationID = 1,
                    ImageUrl = "/images/marijan1.jpeg"
                },
                new Photo
                {
                    ID = 2,
                    AccommodationID = 1,
                    ImageUrl = "/images/marijan2.jpeg"
                },
                new Photo
                {
                    ID = 3,
                    AccommodationID = 1,
                    ImageUrl = "/images/marijan3.jpeg"
                },
                new Photo
                {
                    ID = 4,
                    AccommodationID = 2,
                    ImageUrl = "/images/draga1.jpeg"
                },
                new Photo
                {
                    ID = 5,
                    AccommodationID = 2,
                    ImageUrl = "/images/draga2.jpeg"
                },
                new Photo
                {
                    ID = 6,
                    AccommodationID = 2,
                    ImageUrl = "/images/draga3.jpeg"
                },
                new Photo
                {
                    ID = 7,
                    AccommodationID = 2,
                    ImageUrl = "/images/draga4.jpeg"
                },
                new Photo
                {
                    ID = 8,
                    AccommodationID = 3,
                    ImageUrl = "/images/braco1.jpeg"
                },
                new Photo
                {
                    ID = 9,
                    AccommodationID = 3,
                    ImageUrl = "/images/braco2.jpeg"
                },
                new Photo
                {
                    ID = 10,
                    AccommodationID = 3,
                    ImageUrl = "/images/braco3.jpeg"
                },
                new Photo
                {
                    ID = 11,
                    AccommodationID = 4,
                    ImageUrl = "/images/laura1.jpeg"
                },
                new Photo
                {
                    ID = 12,
                    AccommodationID = 4,
                    ImageUrl = "/images/laura2.jpeg"
                },
                new Photo
                {
                    ID = 13,
                    AccommodationID = 4,
                    ImageUrl = "/images/laura3.jpeg"
                },
                new Photo
                {
                    ID = 14,
                    AccommodationID = 4,
                    ImageUrl = "/images/laura4.jpeg"
                },
                new Photo
                {
                    ID = 15,
                    AccommodationID = 4,
                    ImageUrl = "/images/laura5.jpeg"
                },
                new Photo
                {
                    ID = 16,
                    AccommodationID = 4,
                    ImageUrl = "/images/laura6.jpeg"
                },
                new Photo
                {
                    ID = 17,
                    AccommodationID = 5,
                    ImageUrl = "/images/janko1.jpeg"
                },
                new Photo
                {
                    ID = 18,
                    AccommodationID = 5,
                    ImageUrl = "/images/janko2.jpeg"
                },
                new Photo
                {
                    ID = 19,
                    AccommodationID = 5,
                    ImageUrl = "/images/janko3.jpeg"
                },
                new Photo
                {
                    ID = 20,
                    AccommodationID = 5,
                    ImageUrl = "/images/janko4.jpeg"
                }
            );

        }

    }
}
