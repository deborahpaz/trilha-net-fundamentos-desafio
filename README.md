🔵 DIO - Trilha .NET - Fundamentos 🔵
www.dio.me

💻 Desafio de projeto!
Para este desafio, eu precisei usar meus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

📃 Contexto:

Fui contratada para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo:

🔹 Adicionar um veículo

🔹 Remover um veículo (e exibir o valor cobrado durante o período)

🔹 Listar os veículos

📋 Proposta:

Construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:

![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)


A classe contém três variáveis, sendo:

🔸precoInicial: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

🔸precoPorHora: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

🔸veiculos: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.


A classe contém três métodos, sendo:

🔺AdicionarVeiculo: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

🔺RemoverVeiculo: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

🔺ListarVeiculos: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".


Por último, fazer um menu interativo com as seguintes ações implementadas:

1️⃣ Cadastrar veículo

2️⃣ Remover veículo

3️⃣ Listar veículos

4️⃣ Encerrar

Para complementar esse projeto, adicionei também exceções para o programa não ser interrompido caso tenha alguma entrada diferente do esperado.

