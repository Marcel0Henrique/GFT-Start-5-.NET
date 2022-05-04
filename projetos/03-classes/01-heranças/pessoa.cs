public class Pessoa{

    //* Declarando atributos privados
    public string? nome{get;set;}
    public int idade{get;set;}
    public double altura{get;set;}

    //* Construtor Pessoa
    public Pessoa(string nome, int idade, double altura){
        this.nome = nome;
        this.idade = idade;
        this.altura = altura;
    }

    
}