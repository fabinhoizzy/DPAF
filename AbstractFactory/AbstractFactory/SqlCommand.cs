﻿using System;

namespace AbstractFactory
{
    public class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine(&amp; amp; amp; amp; quot; Executando o comando do sql.....& amp; amp; amp; amp; quot;);
        }
    }
}
