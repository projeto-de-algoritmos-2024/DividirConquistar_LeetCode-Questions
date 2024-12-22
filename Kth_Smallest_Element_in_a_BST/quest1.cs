public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        int InOrderTraversal(TreeNode node, ref int k) {
            if (node == null) return -1;

            int left = InOrderTraversal(node.left, ref k);
            if (k == 0) return left; 

            k--;
            if (k == 0) return node.val;

            return InOrderTraversal(node.right, ref k);
        }
        return InOrderTraversal(root, ref k);
    }
}
