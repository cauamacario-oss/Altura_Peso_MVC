# Altura_Peso_MVC
Checkpoint IX
# Aplicação ASP.NET Core MVC - Cálculo de IMC

Esta aplicação foi desenvolvida para a atividade prática utilizando o padrão **MVC (Model-View-Controller)** no ASP.NET Core. 

## Como Funciona
1. O usuário preenche o formulário com Nome, Peso e Altura na **View**.
2. As regras de validação (*Data Annotations*) garantem que nenhum campo fique vazio ou com dados absurdos antes do envio.
3. Ao enviar, o **Model Binding** captura os dados e envia para a **Controller**.
4. O cálculo é realizado de forma segura no **Server Side** (lado do servidor).
5. A Controller anexa o resultado de volta ao modelo e renderiza a tela exibindo o IMC e sua respectiva classificação.

## Demonstração da Aplicação
![Print da Aplicação](./Print/print_aplicacao.png) 

