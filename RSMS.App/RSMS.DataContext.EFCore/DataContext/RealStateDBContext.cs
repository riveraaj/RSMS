namespace RSMS.DataContext.EFCore.DataContext;

public partial class RealStateDBContext(DbContextOptions<RealStateDBContext> options) : DbContext(options)
{
    public virtual DbSet<OwnerPOCO> Owners { get; set; }

    public virtual DbSet<PropertyPOCO> Properties { get; set; }

    public virtual DbSet<PropertyTypePOCO> PropertyTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OwnerPOCO>(entity =>
        {
            entity.HasKey(e => e.OwnerId).HasName("PK_owner_id");

            entity.ToTable("owner");

            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdentificationNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("identificationNumber");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<PropertyPOCO>(entity =>
        {
            entity.HasKey(e => e.PropertyId).HasName("PK_property_id");

            entity.ToTable("property");

            entity.Property(e => e.PropertyId).HasColumnName("property_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Area)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("area");
            entity.Property(e => e.CosntructionArea)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("cosntruction_area");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PropertyTypeId).HasColumnName("property_type_id");
        });

        modelBuilder.Entity<PropertyTypePOCO>(entity =>
        {
            entity.HasKey(e => e.PropertyTypeId).HasName("PK_property_type_id");

            entity.ToTable("property_type");

            entity.Property(e => e.PropertyTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("property_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}