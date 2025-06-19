using piano_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace piano_store.Data
{
	// Serves as a gateway to the database
	public class PianoStoreDbContext : IdentityDbContext
	{
		public PianoStoreDbContext(DbContextOptions<PianoStoreDbContext>options) : base(options) // pass 'options' variable to base dbcontext class
		{
		}

		// Properties (will be mapped database table name at runtime)
		public DbSet<Product> Products { get; set; }
		public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
		public DbSet<Order> Orders { get; set; }
        	public DbSet<OrderDetail> OrderDetails { get; set; }
        	protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Get a new instance of the Product class and set its properties
			modelBuilder.Entity<Product>().HasData(

				new Product { Id = 1, Name = "Yamaha YDP-165", Detail = "Standard size, 88-key model of the ARIUS digital piano featuring weighted keyboard. With Yamaha's CFX concert grand piano sound as a built-in Voice, experience a luxuriously expressive playing feel with the GH3 keyboard. Includes newly equipped ear-friendly functions, and compatibility with Yamaha’s Smart Pianist app.", Price = 2399, IsTrendingProduct = true, ImageUrl = "https://www.yamaha.com/us/pianos/images/YDP165B.jpg" },
				new Product { Id = 2, Name = "Yamaha CSP-295GP", Detail = "The flagship CSP-295GP features a luxurious, elegant grand piano shape with GrandTouch™ pedals that recreate the precise control of an acoustic grand piano.", Price = 10999, IsTrendingProduct = true, ImageUrl = "https://www.yamaha.com/yamahavgn/PIM/Images/CSP-295GP_PE_a_0001_7a9db7dbaad1955e30fc818bc64030d7_MEDPROC_.jpg" },
				new Product { Id = 3, Name = "Yamaha CLP-735", Detail = "Experience newly sampled Voices of the world-renowned CFX and Bösendorfer Imperial grand pianos, featuring binaural sound, and two new centuries-old Fortepiano Voices that allow you to hear classical music the way their original composers did.", Price = 3199, IsTrendingProduct = true, ImageUrl = "https://www.yamaha.com/us/pianos/images/CLP-735PE_th.jpg" },
				new Product { Id = 4, Name = "Yamaha P-525", Detail = "The flagship model in our P-Series, the P-525 offers authentic grand-piano feel and exquisite sound. Thanks to its range of features and smooth playability, the P-525 is perfectly suited for all levels of players, from beginners to pros. ", Price = 1999, IsTrendingProduct = false, ImageUrl = "https://www.yamaha.com/us/pianos/images/P-525B_th.jpg" },
				new Product { Id = 5, Name = "Yamaha P-225", Detail = "The Yamaha P Series digital pianos. For those who desire the comfortable feel of an acoustic piano in a practical, lightweight design. The P-225 features the sounds of our premier concert grand piano, the CFX, and this model uses Virtual Resonance Modeling (VRM) Lite technology to replicate the expressive moment-by-moment tonal changes that occur in a real grand piano. Whether you are an advanced piano player or a serious beginner looking to learn, the P-225 is the perfect choice.", Price = 999, IsTrendingProduct = false, ImageUrl = "https://www.yamaha.com/us/pianos/images/P-225B.jpg" },
				new Product { Id = 6, Name = "Yamaha U1 Upright", Detail = "Precise, ultra-responsive touch, clear, full-bodied tone and a reputation for reliability have made U Series pianos the choice of professional musicians, conservatories, teachers, students and music lovers, the world over. Add to that our legendary attention to every detail of every piano, and it’s no surprise that the U Series has been the world’s most popular upright for over half a century.", Price = 17999, IsTrendingProduct = false, ImageUrl = "https://www.yamaha.com/us/pianos/images/U1-1-c6f7e2c3.jpg" },
				new Product { Id = 7, Name = "Yamaha C7X Grand", Detail = "CX pianos have been redesigned with many of the innovations of our flagship CFX to give artists a more versatile tonal palette while still maintaining the bright, percussive sound that has helped make C series pianos the most recorded in history.", Price = 82999, IsTrendingProduct = false, ImageUrl = "https://www.yamaha.com/us/pianos/images/c7x.jpg" }

				);
		}
	}
}
