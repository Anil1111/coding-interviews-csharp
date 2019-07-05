using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterviews
{
    /// <summary>
    /// 二叉树
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }

    /// <summary>
    /// 树:重建二叉树
    /// 输入某二叉树的前序遍历和中序遍历的结果，请重建出该二叉树。
    /// 假设输入的前序遍历和中序遍历的结果中都不含重复的数字。
    /// 例如输入前序遍历序列{1,2,4,7,3,5,6,8}和中序遍历序列{4,7,2,1,5,3,8,6}，则重建二叉树并返回。
    /// 前序遍历：根结点 ---> 左子树 ---> 右子树
    /// 中序遍历：左子树---> 根结点 ---> 右子树
    /// 中序遍历：左子树---> 根结点 ---> 右子树
    /// 后序遍历：左子树 ---> 右子树 ---> 根结点
    /// 层次遍历：只需按层次遍历即可
    /// </summary>
    public class Coding004
    {
        /// <summary>
        /// 前序遍历：根结点 ---> 左子树 ---> 右子树
        /// </summary>
        /// <param name="node"></param>
        public static void PreNode(TreeNode node, List<int> treeList)
        {
            if (node != null)
            {
                treeList.Add(node.val);
                PreNode(node.left, treeList);
                PreNode(node.right, treeList);
            }
        }

        /// <summary>
        /// 中序遍历：左子树---> 根结点 ---> 右子树
        /// </summary>
        /// <param name="node"></param>
        public static void MidNode(TreeNode node, List<int> treeList)
        {
            if (node != null) {
                MidNode(node.left, treeList);
                treeList.Add(node.val);
                MidNode(node.right, treeList);
            }
        }

        /// <summary>
        /// 后序遍历：左子树 ---> 右子树 ---> 根结点
        /// </summary>
        /// <param name="node"></param>
        public static void EndNode(TreeNode node, List<int> treeList)
        {
            if (node != null) {
                EndNode(node.left, treeList);
                EndNode(node.right, treeList);
                treeList.Add(node.val);
            }
        }

        /// <summary>
        /// 层次遍历：只需按层次遍历即可
        /// 根据层次遍历的顺序，每一层都是从左到右的遍历输出，借助于一个队列。
        /// 先从根节点入队，将其出队访问，如果当前节点的左节点不为空左节点入队，如果当前右节点部位空右节点入队。所以出队顺序是从左到右。
        /// </summary>
        /// <param name="node"></param>
        public static void LevelNode(TreeNode node, List<int> treeList)
        {
            if (node != null) {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(node);

                TreeNode currentNode = null;
                while (queue.Count > 0) {
                    currentNode = queue.Dequeue();
                    treeList.Add(currentNode.val);
                    if (currentNode.left != null) {
                        queue.Enqueue(currentNode.left);
                    }

                    if (currentNode.right != null) {
                        queue.Enqueue(currentNode.right);
                    }
                }
            }
        }

        /// <summary>
        /// 二叉树的前序遍历和中序遍历的结果，请重建出该二叉树
        /// 根据前序遍历找到根，根据中序遍历找到左右子树，依次递归
        /// 根 > 左 > 右
        /// </summary>
        /// <param name="preTree"></param>
        /// <param name="midTree"></param>
        /// <returns></returns>
        public static TreeNode Tree(List<int> preTree, List<int> midTree)
        {
            if (preTree == null || preTree.Count() == 0 || midTree == null || midTree.Count() == 0)
            {
                return null;
            }

            //根节点
            int rootTree = preTree[0];
            //移除根节点
            preTree.RemoveAt(0);
            TreeNode treeNode = new TreeNode(rootTree);

            //左右子树
            List<int> leftTree = null;
            List<int> tempList = new List<int>();
            bool isTree = false;
            foreach (var item in midTree)
            {
                tempList.Add(item);
                if (item == rootTree)
                {
                    isTree = true;
                    tempList.Remove(item);
                    leftTree = tempList;

                    tempList = new List<int>();
                }
            }
            if (!isTree) {
                Console.WriteLine("不是正确的树");
                return null;
            }
            List<int> rightTree = tempList;

            //递归左右节点
            treeNode.left = Tree(preTree, leftTree);
            treeNode.right = Tree(preTree, rightTree);

            return treeNode;
        }

    }
}
