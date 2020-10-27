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
        }
    }
}