using Microsoft.EntityFrameworkCore;


namespace Domain
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<QuoteDetail> QuoteDetails { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=XUANDUY;Database=RES;User ID=sa;Password=12345;TrustServerCertificate=True;MultipleActiveResultSets=true");
                //optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");
                entity.HasKey(c => c.AccountID);
                entity.HasIndex(e => e.Username)
                    .IsUnique();

                entity.Property(e => e.AccountID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                     .IsUnicode(false);
            });
            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff");
                entity.HasKey(c => c.StaffId);
                entity.HasIndex(c => c.AccountId).IsUnique();


                entity.Property(e => e.StaffId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StaffName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                     .HasMaxLength(100)
                     .IsUnicode(true);
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime");
                entity.HasOne(d => d.Account)
                .WithOne(d => d.Staff)
                .HasForeignKey<Account>(d => d.AccountID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");
                entity.HasKey(c => c.CustomerID);
                entity.HasIndex(c => c.Email).IsUnique();
                entity.HasIndex(c => c.AccountId).IsUnique();


                entity.Property(e => e.CustomerID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(true);

                entity.Property(e => e.LastName)
                     .HasMaxLength(100)
                     .IsUnicode(true);
                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(true);
                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(true);
                entity.Property(e => e.Email)
                   .HasMaxLength(100)
                   .IsUnicode(true);
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime");
                entity.Property(e => e.AccountId);

                entity.HasOne(d => d.Account)
                .WithOne(d => d.Customer)
                .HasForeignKey<Account>(d => d.AccountID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.ToTable("Equipment");
                entity.HasKey(c => c.EquipmentID);
                entity.Property(e => e.EquipmentID)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.EquipmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.UnitPrice);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");
                entity.HasKey(c => c.ProjectID);
                entity.HasIndex(c => c.StaffId);
                entity.HasIndex(c => c.CustomerId);

                entity.Property(e => e.ProjectID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime");
                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime");
                entity.Property(e => e.Status)
                     .HasMaxLength(100)
                     .IsUnicode(false);
                entity.Property(e => e.StaffId)
                     .HasMaxLength(100);
                entity.Property(e => e.CustomerId)
                     .HasMaxLength(100);


                entity.HasOne(d => d.Customer)
                    .WithMany(d => d.Projects)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Staff)
                    .WithMany(d => d.Projects)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");
                entity.HasKey(c => c.MaterialID);

                entity.Property(e => e.MaterialID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(100)
                    .IsUnicode(true);

                entity.Property(e => e.Description)
                     .HasMaxLength(1000)
                     .IsUnicode(true);
                entity.Property(e => e.UnitPrice);
                entity.Property(e => e.Stock);
                entity.Property(e => e.Image);
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime");
            });
            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");
                entity.HasKey(c => c.RoomID);
                entity.HasIndex(c => c.ProjectId);
                entity.Property(e => e.RoomID)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.RoomName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                     .HasMaxLength(1000)
                     .IsUnicode(true);
                entity.Property(e => e.Size);
                entity.Property(e => e.ProjectId);
                entity.HasOne(c => c.Project)
                    .WithMany(c => c.Rooms)
                    .HasForeignKey(c => c.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade);

            });


            modelBuilder.Entity<QuoteDetail>(entity =>
            {
                entity.ToTable("QuoteDetail");
                entity.HasKey(c => c.QuoteID);
                entity.HasIndex(c => c.ProjectID);
                entity.HasIndex(c => c.EquipmentID);
                entity.HasIndex(c => c.MaterialID);
                entity.Property(e => e.QuoteID)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.QuoteNumber);
                entity.Property(e => e.QuoteDate)
                    .HasColumnType("datetime");
                entity.Property(e => e.TotalAmount);
                entity.Property(e => e.ProjectID);
                entity.Property(e => e.EquipmentID);
                entity.Property(e => e.MaterialID);
                entity.HasOne(c => c.Project)
                    .WithMany(c => c.QuoteDetail)
                    .HasForeignKey(c => c.ProjectID)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(c => c.Material)
                    .WithMany(c => c.QuoteDetails)
                    .HasForeignKey(c => c.MaterialID)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(c => c.Equipment)
                    .WithMany(c => c.QuoteDetails)
                    .HasForeignKey(c => c.EquipmentID)
                    .OnDelete(DeleteBehavior.Cascade);

            });

            OnModelCreatingPartial(modelBuilder);

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
