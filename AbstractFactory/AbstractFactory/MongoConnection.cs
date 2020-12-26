using System;

namespace AbstractFactory
{
    public class MongoConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine(&amp; amp; amp; amp; quot; Método Open de Mongo Connection foi chamado...&amp; amp; amp; amp; quot;);
        }
    }
}
