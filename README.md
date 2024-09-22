<h1 align="center">Academia .NET - Exercícios POO Listas</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 6" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
</p>

## :computer: Projeto

Repositório com exercícios sobre `Programação Orientada a Objetos` e o uso de `Listas`, as estruturas dos projetos foram desenvolvidas utilizando a linguagem `C#` durante a Academia .NET promovida pela `Universidade Franciscana - UFN`. 

## :page_facing_up: Lista dos Exercícios

1 - Crie uma classe Produto com atributos como nome, preço e quantidade em estoque. Implemente um construtor e métodos para adicionar e remover itens do estoque.

2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de compras (data, produto, valor). Implemente um construtor e métodos para adicionar e listar compras.
  
3 - Crie uma classe CorretoraDeImoveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo). Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio. Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis. Insira os imoveis numa lista para facilitar o trabalho.
  
4 - Crie uma classe AgendaTelefonica com atributos para armazenar contatos (nome, telefone, e-mail). Implemente um construtor e métodos para adicionar numa lista, remover e buscar contatos.
  
5 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento). Implemente um construtor e métodos para adicionar, remover e listar tarefas. Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje.
  
6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código.
  
7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora. Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist. Implemente um método para adicionar músicas na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música). Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.

8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.  Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco. Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo.
  
9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor. Utilize o encapsulamento  para garantir que o título e o autor não sejam vazios.
  
10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado EmitirSom, que imprime na tela o som do animal.
  
11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).

12 - Crie uma classe Agenda que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
  - void armazenaPessoa(String nome, int idade, float altura);
  - void removePessoa(String nome);
  - Pessoa buscaPessoa(String nome); retorna a pessoa com o nome informado
  - void imprimeAgenda(); imprime os dados de todas as pessoas da agenda
  - Faça um menu para navegar entre as opções infinitamente.

## :white_check_mark: Decisões Técnicas

Nas respostas dos exercícios de 1 a 7, procurei manter o que tinham sido abordados durante as aulas, como por exemplo:

- Para a utilziação das variávels usei a visibilidade `public` conforme os exemplos nas aulas. 

- Outro recurso que procurei aplicar foi o de `Associação` nos relacionamentos entre os objetos, possivelmente os outros tipos de relacionamentos como `Agregação` ou `Composição` possam ser recomendados em futuros exercícios.

<hr>

Nas respostas dos exercícios de 8 a 12, assim como nos primeiros exercícios, procurei manter o que tinham sido abordados durante as aulas, como por exemplo:

- Foram feitos nesses exercícios o uso do `Encapsulamento` nas classes.

- adição dos métodos acessores `getters` e `setters`, a linguagem C# tem algumas formas diferentes de aplicação para esses métodos, eu decidi usar o mesmo tipo de estrutura que foi mostrada em aula com o objetivo de deixar um pouco mais explícita a utilização do `Encapsulamento`.

- No exercício 9 optei em criar um método com vizibilidade privada para validar os campos `Título` e `Autor`, a minha motivação para isso é procurar manter um código mais limpo e organizado com o objetvo de deixar a sua leitura mais prática.   

- No exercício 12 decici fazer a criação de uma classe chamada `Pessoa` com as variáveis `nome` `idade` e `altura`, na classe `Agenda` fiz a inicialização de uma lista de pessoas passanado exatamente a classe `Pessoa`, escolhi aplicar essa abordagem porque analisando melhor fez mais sentido passar um objeto em uma lista de contatos nesse cenário.

- Nos exercícios além dos que foram solicitados eu decidi criar `entradas de dados`, tomei essa decisão pensando no lado do usuário, o objetivo foi tentar simular na medida do possível projetos reais.

- Nos demais exercícios procurei manter um padrão de desenvolvimento nas respostas, a intenção é facilitar a análise e leitura de meus códigos nesses projetos.

## :page_facing_up: Links dos Exercícios

- [Desafio 1](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio01)
- [Desafio 2](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio02)
- [Desafio 3](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio03)
- [Desafio 4](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio04)
- [Desafio 5](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio05)
- [Desafio 6](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio06)
- [Desafio 7](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio07)
- [Desafio 8](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio08)
- [Desafio 9](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio09)
- [Desafio 10](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio10)
- [Desafio 11](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio11)
- [Desafio 12](https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas/tree/master/ExerciciosPOO/Academia.Dotnet.POO.Exercicio12)

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``Console Application``
- ``C#``

## :floppy_disk: Clonar Repositório

```bash
git clone https://github.com/PauloAlves8039/academia-dotnet-exercicios-poo-listas.git
```

## :boy: Author

<a href="https://github.com/PauloAlves8039"><img src="https://avatars.githubusercontent.com/u/57012714?v=4" width=70></a>
[Paulo Alves](https://github.com/PauloAlves8039)
