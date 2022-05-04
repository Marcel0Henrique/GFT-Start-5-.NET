public class Pessoa{

    //* Declarando atributos privados
    private string? nome{get;set;}
    private int idade;
    private double altura;

    //* Construtor Pessoa
    public Pessoa(string nome, int idade, double altura){
        this.nome = nome;
        this.idade = idade;
        this.altura = altura;
    }

    
}