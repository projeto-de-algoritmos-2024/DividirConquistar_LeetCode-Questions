# Recover a Tree From Preorder Traversal

## Nome

Recover a Tree From Preorder Traversal

## Descrição

Um algoritmo para reconstruir uma árvore binária a partir de uma string representando sua travessia pré-ordem com níveis de profundidade.

## Funcionalidades

- Reconstruir uma árvore binária com base na profundidade dos nós.
- Processar uma string com dashes (`-`) para determinar a hierarquia.
- Suportar árvores com múltiplos níveis.

## Detalhes Técnicos

- Utiliza recursão para reconstruir subárvores com base na profundidade.
- Processa a string de entrada sequencialmente para determinar os nós.

## Principais Métodos

### `RecoverFromPreorder(string traversal)`

- **Objetivo**: Reconstruir a árvore binária a partir da string de entrada.
- **Parâmetros**:
  - `traversal`: String de entrada representando a travessia pré-ordem com níveis.
- **Retorno**:
  - Raiz da árvore reconstruída.

## Utilização do Dividir e Conquistar

- **Divisão**: Divide a string em partes representando subárvores com base na profundidade dos nós.
- **Conquista**: Constrói recursivamente as subárvores esquerda e direita.
- **Combinação**: As subárvores são conectadas para formar a árvore final.
