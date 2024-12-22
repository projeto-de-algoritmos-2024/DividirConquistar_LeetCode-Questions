public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        int CountNodes(TreeNode node) {
            if (node == null) return 0;
            return 1 + CountNodes(node.left) + CountNodes(node.right);
        }
        
        int leftCount = CountNodes(root.left); 
        
        if (k <= leftCount) {
            return KthSmallest(root.left, k);
        } else if (k == leftCount + 1) {
            return root.val;
        } else {
            return KthSmallest(root.right, k - leftCount - 1);
        }
    }
}