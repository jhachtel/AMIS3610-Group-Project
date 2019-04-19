using System;

namespace AMIS3610.GroupProject
{
    public class ProjectCredentials
    {
        private string pgSqlConnection = "Server=off-the-trail.postgres.database.azure.com;Database=OFF_THE_TRAIL_main;Port=5432;User Id=amis3610@off-the-trail;Password=mKJc7vbH8xfB#;Ssl Mode=Require;"

        public string GetSqlConnection() {
            return pgSqlConnection;
        }
    }
}