using CodingInterviews;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding004Test
    {

        /// <summary>
        /// 普通二叉树
        ///              1
        ///           /     \
        ///          2       3  
        ///         /       / \
        ///        4       5   6
        ///         \         /
        ///          7       8        
        /// </summary>
        [Fact]
        public void Common() {
            int[] preTree = { 1, 2, 4, 7, 3, 5, 6, 8 };
            int[] midTree = { 4, 7, 2, 1, 5, 3, 8, 6 };
            TreeNode tree = Coding004.Tree(preTree.ToList(), midTree.ToList());
            List<int> result = new List<int>();
            Coding004.PreNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(preTree), JsonConvert.SerializeObject(result));

            result.Clear();
            Coding004.MidNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(midTree), JsonConvert.SerializeObject(result));
        }


        /// <summary>
        /// 所有结点都没有右子结点
        ///            1
        ///           / 
        ///          2   
        ///         / 
        ///        3 
        /// </summary>
        [Fact]
        public void Right()
        {
            int[] preTree = { 1, 2, 3 };
            int[] midTree = { 3, 2, 1 };
            TreeNode tree = Coding004.Tree(preTree.ToList(), midTree.ToList());
            List<int> result = new List<int>();
            Coding004.PreNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(preTree), JsonConvert.SerializeObject(result));

            result.Clear();
            Coding004.MidNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(midTree), JsonConvert.SerializeObject(result));
        }

        /// <summary>
        /// 所有结点都没有左子结点
        ///            1
        ///             \ 
        ///              2   
        ///               \ 
        ///                3 
        ///                 \
        ///
        ///                   \
        ///                    5
        /// </summary>
        [Fact]
        public void Left()
        {
            int[] preTree = { 1, 2, 3, 4, 5 };
            int[] midTree = { 1, 2, 3, 4, 5 };
            TreeNode tree = Coding004.Tree(preTree.ToList(), midTree.ToList());
            List<int> result = new List<int>();
            Coding004.PreNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(preTree), JsonConvert.SerializeObject(result));

            result.Clear();
            Coding004.MidNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(midTree), JsonConvert.SerializeObject(result));
        }

        /// <summary>
        /// 树中只有一个结点
        /// </summary>
        [Fact]
        public void One()
        {
            int[] preTree = { 1 };
            int[] midTree = { 1 };
            TreeNode tree = Coding004.Tree(preTree.ToList(), midTree.ToList());
            List<int> result = new List<int>();
            Coding004.PreNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(preTree), JsonConvert.SerializeObject(result));

            result.Clear();
            Coding004.MidNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(midTree), JsonConvert.SerializeObject(result));
        }

        /// <summary>
        /// 完全二叉树
        ///              1
        ///           /    \
        ///          2      3  
        ///         / \     / \
        ///        4   5   6   7
        /// </summary>
        [Fact]
        public void All()
        {
            int[] preTree = { 1, 2, 4, 5, 3, 6, 7 };
            int[] midTree = { 4, 2, 5, 1, 6, 3, 7 };
            TreeNode tree = Coding004.Tree(preTree.ToList(), midTree.ToList());
            List<int> result = new List<int>();
            Coding004.PreNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(preTree), JsonConvert.SerializeObject(result));

            result.Clear();
            Coding004.MidNode(tree, result);
            Assert.Equal(JsonConvert.SerializeObject(midTree), JsonConvert.SerializeObject(result));
        }

    }
}
