public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        int CountNodes(TreeNode node) {
            if (node == null) return 0;
            return 1 + CountNodes(node.left) + CountNodes(node.right);
        }
        
        int leftCount = CountNodes(root.left); //Implementaçao do Dividir e Conquistar
        
        if (k <= leftCount) { //Implementaçao do Dividir e Conquistar
            return KthSmallest(root.left, k); //Implementaçao do Dividir e Conquistar
        } else if (k == leftCount + 1) { //Implementaçao do Dividir e Conquistar
            return root.val; //Implementaçao do Dividir e Conquistar
        } else { //Implementaçao do Dividir e Conquistar
            return KthSmallest(root.right, k - leftCount - 1); //Implementaçao do Dividir e Conquistar
        }
    }
}