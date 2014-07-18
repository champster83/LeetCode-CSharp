  //Given a binary tree, return the inorder traversal of its nodes' values.

  //For example:
  //Given binary tree {1,#,2,3},
  
  //   1
  //    \
  //     2
  //    /
  //   3
  
  //return [1,3,2]. 
  
  public void InorderRecursive(TreeNode root,List<int> inorderList)
  {
      if (root == null)
          return;
  
      InorderRecursive(root.left,inorderList);
      inorderList.Add(root.val);
      InorderRecursive(root.right,inorderList);
  }
  
  public List<int> InorderIterative(TreeNode root)
  {
      if (root == null)
          return null;
  
      TreeNode curr = root;
      List<int> inorderList = new List<int>();
      Stack<TreeNode> stack = new Stack<TreeNode>();
      while (curr != null)
      {
          stack.Push(curr);
          curr = curr.left;
      }
  
      while (stack.Count > 0)
      {
          curr = stack.Pop();
          inorderList.Add(curr.val);
          if (curr.right != null)
          {
              curr = curr.right;
              while (curr != null)
              {
                  stack.Push(curr);
                  curr = curr.left;
              }
          }
      }
      return inorderList;
  }
