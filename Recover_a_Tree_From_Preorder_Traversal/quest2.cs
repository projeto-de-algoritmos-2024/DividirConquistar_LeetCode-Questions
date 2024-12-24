public class Solution {
    public TreeNode RecoverFromPreorder(string traversal) {
        int index = 0;

        TreeNode Recover(int depth) {
            int currentDepth = 0; //Implementacao do Dividir e Conquistar
            while (index < traversal.Length && traversal[index] == '-') { //Implementacao do Dividir e Conquistar
                currentDepth++; //Implementacao do Dividir e Conquistar
                index++; //Implementacao do Dividir e Conquistar
            }

            if (currentDepth != depth) { //Implementacao do Dividir e Conquistar
                index -= currentDepth;  //Implementacao do Dividir e Conquistar
                return null; //Implementacao do Dividir e Conquistar
            }

            int value = 0;
            while (index < traversal.Length && char.IsDigit(traversal[index])) {
                value = value * 10 + (traversal[index] - '0');
                index++;
            }

            TreeNode node = new TreeNode(value); //Implementacao do Dividir e Conquistar
            node.left = Recover(depth + 1); //Implementacao do Dividir e Conquistar
            node.right = Recover(depth + 1); //Implementacao do Dividir e Conquistar

            return node;
        }
        return Recover(0);
    }
}
