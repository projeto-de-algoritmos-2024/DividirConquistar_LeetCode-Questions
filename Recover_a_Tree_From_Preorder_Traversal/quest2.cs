public class Solution {
    public TreeNode RecoverFromPreorder(string traversal) {
        int index = 0;

        TreeNode Recover(int depth) {
            int currentDepth = 0;
            while (index < traversal.Length && traversal[index] == '-') {
                currentDepth++;
                index++;
            }

            if (currentDepth != depth) {
                index -= currentDepth; 
                return null;
            }

            int value = 0;
            while (index < traversal.Length && char.IsDigit(traversal[index])) {
                value = value * 10 + (traversal[index] - '0');
                index++;
            }

            TreeNode node = new TreeNode(value);
            node.left = Recover(depth + 1);
            node.right = Recover(depth + 1);

            return node;
        }
        return Recover(0);
    }
}
