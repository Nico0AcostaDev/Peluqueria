﻿namespace peluqueria.AccesoDatos
{
    public  class Connect
    {
        public static string ConnectionString()
        {
            //return "Server=(localdb)\\MSSQLLocalDB;DataBase= Peluqueria;Integrated Security=true";
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Peluqueria;Integrated Security=True";
        }
    }
}
