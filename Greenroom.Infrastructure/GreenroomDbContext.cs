using Greenroom.Application.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Greenroom.Infrastructure;

public class GreenroomDbContext : DbContext, IGreenroomDbContext
{
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<UserCourse> UserCourses { get; set; }
    public virtual DbSet<Assignment> Assignments { get; set; }
    public virtual DbSet<AssignmentResponse> AssignmentResponses { get; set; }
    public virtual DbSet<Material> Materials { get; set; }
    public virtual DbSet<ResponseMaterial> ResponseMaterials { get; set; }

    public GreenroomDbContext(DbContextOptions<GreenroomDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(user =>
        {
            user.ToTable("Users");
            user.HasKey(user => user.Id);
            user.Property(user => user.FirstName).HasMaxLength(60).IsRequired();
            user.Property(user => user.LastName).HasMaxLength(60).IsRequired();
            user.Property(user => user.Password).HasMaxLength(100).IsRequired();
            user.Property(user => user.Email).HasMaxLength(250).IsRequired();
            user.HasIndex(user => user.Email).IsUnique();
        });

        modelBuilder.Entity<Course>(course =>
        {
            course.ToTable("Courses");
            course.HasKey(course => course.Id);
            course.Property(course => course.Title).HasMaxLength(50).IsRequired();
            course.Property(course => course.Description).HasMaxLength(500).IsRequired(false).HasDefaultValue(null);
        });

        modelBuilder.Entity<UserCourse>(uc =>
        {
            uc.ToTable("UserCourses");
            uc.HasKey(uc => uc.Id);
            uc.Property(uc => uc.IsInstructor).IsRequired().HasDefaultValue(false);
            uc.HasOne(uc => uc.Course)
                .WithMany(c => c.UserCourses)
                .HasForeignKey(uc => uc.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
            uc.HasOne(uc => uc.User)
                .WithMany(u => u.UserCourses)
                .HasForeignKey(uc => uc.UserId) 
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Assignment>(a =>
        {
            a.ToTable("Assignments");
            a.HasKey(a => a.Id);
            a.Property(assign => assign.Name).HasMaxLength(50).IsRequired();
            a.Property(assign => assign.Description).HasMaxLength(300).IsRequired(false).HasDefaultValue(null);
            a.Property(assign => assign.MaxValue).HasColumnType("decimal(4,2)").HasDefaultValue(null);
            a.HasOne(a => a.Course)
                .WithMany(c => c.Assignments)
                .HasForeignKey(a => a.CourseId) 
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<AssignmentResponse>(ar => {
            ar.ToTable("AssignmentResponses");
            ar.HasKey(a => a.Id);
            ar.Property(ar => ar.ResponseBody).HasMaxLength(1500).IsRequired(false).HasDefaultValue(null);
            ar.HasOne(ar => ar.Assignment)
                .WithMany(a => a.AssignmentResponses)
                .HasForeignKey(ar => ar.AssignmentId)
                .OnDelete(DeleteBehavior.Cascade); // For now, I will need to think about this
            ar.HasOne(ar => ar.User)
                .WithMany(u => u.AssignmentResponses)
                .HasForeignKey(ar => ar.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Material>(m =>
        {
            m.ToTable("Materials");
            m.HasKey(material => material.Id);
            m.Property(material => material.Name).HasMaxLength(50).IsRequired();
            m.Property(material => material.Description).HasMaxLength(500).IsRequired(false).HasDefaultValue(null);
            m.Property(material => material.Attachment).HasColumnType("varbinary(max)");
            m.Property(material => material.Url).HasMaxLength(1000).IsRequired(false).HasDefaultValue(null);
        });

        modelBuilder.Entity<ResponseMaterial>(rm =>
        {
            rm.ToTable("ResponseMaterials");
            rm.HasKey(rm => rm.Id);
            rm.HasOne(rm => rm.AssignmentResponse)
                .WithMany(ar => ar.ResponseMaterials)
                .HasForeignKey(rm => rm.ResponseId)
                .OnDelete(DeleteBehavior.Cascade);
            rm.HasOne(rm => rm.Material)
                .WithMany(m => m.ResponseMaterials)
                .HasForeignKey(rm => rm.MaterialId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
