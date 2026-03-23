namespace ExFixacao3_ClassAtribMet
{
    internal class Aluno
    {
        private string Nome { get; set; }
        private double Nota1 { get; set; }
        private double Nota2 { get; set; }
        private double Nota3 { get; set; }

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalcularNota()
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}