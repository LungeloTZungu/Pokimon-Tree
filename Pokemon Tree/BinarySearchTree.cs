using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Tree
{
   public  class BinarySearchTree
    {

        public TreeNode Root { get; set; } = null;
        public void Insert(int key,string value)
        {
            Root = InsertItem(Root, key, value);
        }

        public TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode treeNode = new TreeNode(key, value);
            // IF this is the first time you insert we create the root
            if(node == null)
            {
                node = treeNode;
                return node;
            }
            // If this isnt the first inert, traverse and find null and insert
            if(key < node.Key)
            {
                node.leftChild = InsertItem(node.leftChild, key, value);
            }
            else
            {
                node.rightChild = InsertItem(node.rightChild, key, value);
            }
            return node;
        }

        public string Find(int key)
        {
            TreeNode tree = Find(Root,key);
            return tree == null ? null : tree.Value;

        }

        private TreeNode Find(TreeNode node , int key)
        {
            if(node == null || node.Key == key)
            {
                return node;
            } else if(key < node.Key)
            {
                return Find(node.leftChild, key);
            } else if(key > node.Key)
            {
                return Find(node.rightChild, key);
            }

            return null;
        }
    }
}
