using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");
            Property(x => x.Nome).HasMaxLength(60).IsRequired();
            Property(x => x.ISBN).HasMaxLength(32).IsRequired();
            Property(x => x.DataLancamento).IsRequired();

            HasKey(x => x.Id);


            //HasKey(x => x.Id);
            //Property(x => x.Title).HasMaxLength(255).IsRequired();
            //Property(x => x.Price).IsRequired().HasColumnType("Money");
            //Property(x => x.ReleaseDate).IsRequired();
            //HasMany(x => x.Authors).WithMany(x => x.Books);
        }
    }
}