using System;

namespace AbstractFactory
{
    public class SqlConnection : DbConnection
    {
        private object amp;

        /* Concret Product */
        public override object Open()
        {
            Console.WriteLine(&amp; amp; amp; amp; quot; Método Open de SQL Connection foi chamado...&amp; amp; amp; amp; quot;);
        }
    }
}
