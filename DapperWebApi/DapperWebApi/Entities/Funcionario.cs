﻿namespace DapperWebApi.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public int EmpresaId { get; set; }
    }
}
