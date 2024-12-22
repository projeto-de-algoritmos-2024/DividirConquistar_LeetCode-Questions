# Kth Smallest Element in a BST

## Nome

Kth Smallest Element in a BST

## Descrição

Um algoritmo para encontrar o k-ésimo menor elemento em uma árvore binária de busca (BST).

## Funcionalidades

- Percorrer a árvore de forma eficiente para encontrar o elemento desejado.
- Utilizar a propriedade de uma BST para otimizar a busca.
- Dividir o problema em subárvores para calcular o k-ésimo menor elemento.

## Detalhes Técnicos

- Implementado com a técnica de Dividir e Conquistar.
- Utiliza recursão para determinar qual subárvore contém o k-ésimo menor elemento.
- Otimizado para calcular o número de nós em subárvores.

## Principais Métodos

### `KthSmallest(TreeNode root, int k)`

- **Objetivo**: Encontrar o k-ésimo menor elemento na BST.
- **Parâmetros**:
  - `root`: Raiz da árvore.
  - `k`: Posição do elemento desejado.
- **Retorno**:
  - Valor do k-ésimo menor elemento.

## Utilização do Dividir e Conquistar

- **Divisão**: O problema é dividido em subárvores esquerda e direita com base no tamanho da subárvore esquerda.
- **Conquista**: A subárvore relevante (esquerda ou direita) é processada recursivamente para encontrar o k-ésimo menor elemento.
- **Combinação**: O resultado é retornado diretamente quando a posição do elemento é encontrada.
