using PrintStudio.Models;

namespace PrintStudio.Data;

public static class SeedData
{
    public static void Initialize(AppDbContext context)
    {
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product
                {
                    Name = "Akrilna boja Basic Set (12x22ml)",
                    Category = "Setovi",
                    ProductType = "Studentska",
                    Brand = "ColorMuse",
                    Description = "Ulazni set živih nijansi idealan za početnike i hobi umjetnike.",
                    Price = 15.90m,
                    OldPrice = 19.90m,
                    IsOnSale = true,
                    IsBestSeller = true,
                    ImageUrl = "https://images.unsplash.com/photo-1579762593131-b8945254345c"
                },
                new Product
                {
                    Name = "Akrilna boja Pro Titanium White 250ml",
                    Category = "Pojedinačne boje",
                    ProductType = "Profesionalna",
                    Brand = "AtelierPro",
                    Description = "Visokopigmentirana bijela boja s izvrsnom pokrivnošću i postojanošću.",
                    Price = 9.80m,
                    IsOnSale = false,
                    IsBestSeller = true,
                    ImageUrl = "https://images.unsplash.com/photo-1460661419201-fd4cecdf8a8b"
                },
                new Product
                {
                    Name = "Fluid Acrylic Neon Pack (6x100ml)",
                    Category = "Setovi",
                    ProductType = "Fluid",
                    Brand = "FlowArt",
                    Description = "Neonske fluid boje za pouring tehnike i apstraktne radove.",
                    Price = 24.50m,
                    OldPrice = 29.90m,
                    IsOnSale = true,
                    IsBestSeller = false,
                    ImageUrl = "https://images.unsplash.com/photo-1452802447250-470a88ac82bc"
                },
                new Product
                {
                    Name = "Heavy Body Crimson Red 120ml",
                    Category = "Pojedinačne boje",
                    ProductType = "Heavy Body",
                    Brand = "StudioMaster",
                    Description = "Gusta tekstura za impasto tehniku i izražajne poteze kistom.",
                    Price = 7.20m,
                    IsOnSale = false,
                    IsBestSeller = false,
                    ImageUrl = "https://images.unsplash.com/photo-1513364776144-60967b0f800f"
                },
                new Product
                {
                    Name = "Akrilni medij Gloss Varnish 200ml",
                    Category = "Mediji i lakovi",
                    ProductType = "Lak",
                    Brand = "ArtShield",
                    Description = "Zaštitni sjajni završni sloj koji pojačava dubinu boja.",
                    Price = 11.40m,
                    OldPrice = 13.40m,
                    IsOnSale = true,
                    IsBestSeller = true,
                    ImageUrl = "https://images.unsplash.com/photo-1515405295579-ba7b45403062"
                },
                new Product
                {
                    Name = "Gesso Primer 500ml",
                    Category = "Priprema podloge",
                    ProductType = "Primer",
                    Brand = "CanvasLab",
                    Description = "Kvalitetna baza za bolju adheziju akrila na platno i drvo.",
                    Price = 12.90m,
                    IsOnSale = false,
                    IsBestSeller = true,
                    ImageUrl = "https://images.unsplash.com/photo-1461344577544-4e5dc9487184"
                }
            );
        }

        if (!context.Testimonials.Any())
        {
            context.Testimonials.AddRange(
                new Testimonial { CustomerName = "Ana K.", Rating = 5, Comment = "Pigmentacija je vrhunska, boje ostaju intenzivne i nakon sušenja.", AvatarUrl = "https://i.pravatar.cc/120?img=5" },
                new Testimonial { CustomerName = "Marko P.", Rating = 5, Comment = "Narudžba je stigla brzo, a proizvodi su odlično zapakirani.", AvatarUrl = "https://i.pravatar.cc/120?img=12" },
                new Testimonial { CustomerName = "Ivana R.", Rating = 4, Comment = "Odličan omjer cijene i kvalitete za studentske i pro setove.", AvatarUrl = "https://i.pravatar.cc/120?img=28" }
            );
        }

        context.SaveChanges();
    }
}
