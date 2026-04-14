using PrintStudio.Models;

namespace PrintStudio.Data;

public static class SeedData
{
    public static void Initialize(AppDbContext context)
    {
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product { Name = "Pozivnice za vjenčanje", Category = "Vjenčanja", Description = "Elegantne i personalizirane pozivnice.", Price = 2.5m, ImageUrl = "https://images.unsplash.com/photo-1519741497674-611481863552" },
                new Product { Name = "Rođendanske čestitke", Category = "Rođendani", Description = "Unikatne čestitke za sve uzraste.", Price = 1.8m, ImageUrl = "https://images.unsplash.com/photo-1464349153735-7db50ed83c84" },
                new Product { Name = "Poslovne vizitke", Category = "Business", Description = "Minimalistički i premium dizajn vizitki.", Price = 0.7m, ImageUrl = "https://images.unsplash.com/photo-1573497019940-1c28c88b4f3e" }
            );
        }

        if (!context.Testimonials.Any())
        {
            context.Testimonials.AddRange(
                new Testimonial { CustomerName = "Ana K.", Rating = 5, Comment = "Kvaliteta tiska je vrhunska, a dostava brza!", AvatarUrl = "https://i.pravatar.cc/120?img=5" },
                new Testimonial { CustomerName = "Marko P.", Rating = 5, Comment = "Od ideje do realizacije sve je bilo profesionalno.", AvatarUrl = "https://i.pravatar.cc/120?img=12" },
                new Testimonial { CustomerName = "Ivana R.", Rating = 4, Comment = "Odlična komunikacija i personalizacija.", AvatarUrl = "https://i.pravatar.cc/120?img=28" }
            );
        }

        context.SaveChanges();
    }
}
