using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DAL.MODEL;

namespace DAL.MAPPING
{

    //Construindo relacionamentos e configurando tipos do meu modelo com EntityFramework Fluent API.
    //https://medium.com/@manacespereira/construindo-relacionamentos-e-configurando-tipos-do-meu-modelo-com-entityframework-fluent-api-52ac13ce359b

    public class ExemploRelacionamentodeFluentAPI : EntityTypeConfiguration<Cliente>
    {

        //MODELOS
        //
        //public class Post
        //{
        //    public int Id { get; set; }
        //    public string Title { get; set; }
        //    public string Slug { get; set; }
        //    public bool Pusblished { get; set; }
        //    public DateTime CreatedAt { get; set; }
        //    public DateTime UpdatedAt { get; set; }
        //}

        //public class Category
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Description { get; set; }
        //    public DateTime CreatedAt { get; set; }
        //    public DateTime UpdatedAt { get; set; }
        //}

        //*************************************************************************************

        //public PostMap()  (N para N)
        //{
        //    // defino o nome da tabela no banco
        //          ToTable("Posts");
        //    // defino a chave primária
        //          HasKey(p => p.Id);
        //    // A propriedade Title é configurada respectivamente com:
        //    // Máximo de Caracters = 255
        //    // É única, ou seja, não haverá títulos iguais.
        //    // É obrigatório, ou seja, não pode ser nulo.
        //          Property(p => p.Title).HasMaxLength(255).IsUnicode().IsRequired();
        //          Property(p => p.CreatedAt).IsRequired();
        //    // A propriedade Title é configurada respectivamente com:
        //    // Opcional, ou seja, poderá ser nula.
        //          Property(p => p.UpdatedAt).IsOptional();
        //          Property(p => p.Slug).HasMaxLength(255).IsUnicode().IsRequired();
        //    // Relacionamento de N para N
        //          HasMany(c => c.Categories)
        //          .WithMany(p => p.Posts)
        //          .Map(pc =>
        //            pc.ToTable("PostsCategories") // Nome da tabela de relacionamento que será criada. 
        //                .MapLeftKey("PostId") // Nome da chave estrangeira de Post
        //                .MapRightKey("CategoryId")); // Nome da chave estrangeira de Category
        //}


        //public CategoryMap()
        //{
        //    // defino o nome da tabela no banco
        //    ToTable("Categories");
        //    // defino a chave primária
        //    HasKey(p => p.Id);

        //    Property(p => p.Name).HasMaxLength(55).IsUnicode().IsRequired();
        //    Property(p => p.Description).HasMaxLength(255).IsRequired();
        //    Property(p => p.CreatedAt).IsRequired();
        //    Property(p => p.UpdatedAt).IsOptional();
        //    //Não precisamos criar um relacionamento aqui, pois já fizemos isso no mapeamento de Post
        //}
    }
}


