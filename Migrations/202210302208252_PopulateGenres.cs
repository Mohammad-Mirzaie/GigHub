namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Id, Name) values(1, 'Jazz')");
            Sql("insert into Genres (Id, Name) values(2, 'Blues')");
            Sql("insert into Genres (Id, Name) values(3, 'Rock')");
            Sql("insert into Genres (Id, Name) values(4, 'Country')");
            Sql("insert into Genres (Id, Name) values(5, 'Classic')");
        }
        
        public override void Down()
        {
            Sql("delelte from genres where id in (1, 2, 3, 4,5)");
        }
    }
}
