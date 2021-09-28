// PROP - cria a propriedade

using System;

namespace API.Models
{
    public class Funcionario
    {
        public Funcionario() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Matricula: {Matricula} | Criado Em: {CriadoEm} ";
        
    }
}