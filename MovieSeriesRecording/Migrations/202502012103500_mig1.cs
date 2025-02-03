namespace MovieSeriesRecording.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        /*
         Projemizde yeni bir Entitie eklediğimiz zaman veya sildiğimiz zaman
        bunu Migration yapmamız gerekiyor.
        Mesela ben burada sonrada Category entitisi ekledim.
        Daha sonra Package Manager Console'dan add-migration mig1 adında yeni bir mig sınıfı oluşturdum.
        Oluşturduğum bu sınıf(şu an içinde bulunduğun sınıf) yaptığım ekleme işlemini gösteriyor.
        Bu sınıf oluştuktan sonra tekrardan update-database diyerek Code First üzerindeki değişikliği veri tabanıma entegre ettim.
         */
        public override void Up() //Update Metodu
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryTitle = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
