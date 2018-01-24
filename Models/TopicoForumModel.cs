using System;

namespace WebApiForum.Models
{
    public class TopicoForumModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}