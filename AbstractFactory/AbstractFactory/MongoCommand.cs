﻿using System;

namespace AbstractFactory
{
    public class MongoCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine(&amp; amp; amp; amp; quot; Executando o comando do sql do Mongo.....& amp; amp; amp; amp; quot;);
        }
    }
}
