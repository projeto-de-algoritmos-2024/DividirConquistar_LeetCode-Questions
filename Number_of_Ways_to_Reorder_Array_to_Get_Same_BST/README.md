# Number of Ways to Reorder Array to Get Same BST

## Nome

Number of Ways to Reorder Array to Get Same BST

## Descrição

Um algoritmo para contar o número de formas diferentes de reordenar um array para obter a mesma árvore binária de busca.

## Funcionalidades

- Dividir o array em sublistas baseadas na estrutura da BST.
- Utilizar coeficientes do triângulo de Pascal para calcular combinações.
- Contar todas as formas possíveis de reordenar o array.

## Detalhes Técnicos

- Baseado no cálculo de combinações de listas.
- Implementado com recursão para processar sublistas.
- Utiliza um triângulo de Pascal para otimização.

## Principais Métodos

### `NumOfWays(int[] nums)`

- **Objetivo**: Calcular o número de formas de reordenar o array para obter a mesma BST.
- **Parâmetros**:
  - `nums`: Array de entrada.
- **Retorno**:
  - Número de formas possíveis, módulo \(10^9 + 7\).

## Utilização do Dividir e Conquistar

- **Divisão**: Divide o array em duas sublistas (`left` e `right`) com base no valor do nó raiz.
- **Conquista**: Calcula recursivamente o número de formas de reordenar cada sublista.
- **Combinação**: Combina os resultados das sublistas usando coeficientes do triângulo de Pascal.
