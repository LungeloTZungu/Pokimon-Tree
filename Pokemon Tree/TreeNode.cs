using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Tree
{
   public  class TreeNode
    {
        public int Key { get; set; } // pokimon keyId
        public string Value { get; set; } // pokimon name
        public TreeNode leftChild{ get; set; }
        public TreeNode rightChild{ get; set; }

        public TreeNode(int key, string value)
        {
            this.Key = key;
            this.Value = value;
        }



    }
}
