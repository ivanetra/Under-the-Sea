﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     // Class containing left and 
    // right child of current  
    // node and key value 
    // class Node  
    // { 
    //     int key; 
    //     Node left, right; 
  
    //     public Node(int item)  
    //     { 
    //         key = item; 
    //         left = right = null; 
    //     } 
    // } 
  
    // // Root of BST 
    // Node root; 
  
    // // Constructor 
    // GFG()  
    // {  
    //     root = null;  
    // } 
  
    // // This method mainly 
    // // calls insertRec() 
    // void insert(int key) 
    // { 
    //     root = insertRec(root, key); 
    // } 
      
    // /* A recursive function to  
    // insert a new key in BST */
    // Node insertRec(Node root, int key)  
    // { 
  
    //     /* If the tree is empty, 
    //     return a new node */
    //     if (root == null)  
    //     { 
    //         root = new Node(key); 
    //         return root; 
    //     } 
  
    //     /* Otherwise, recur 
    //     down the tree */
    //     if (key < root.key) 
    //         root.left = insertRec(root.left, key); 
    //     else if (key > root.key) 
    //         root.right = insertRec(root.right, key); 
  
    //     /* return the root */
    //     return root; 
    // } 
      
    // // A function to do  
    // // inorder traversal of BST 
    // void inorderRec(Node root)  
    // { 
    //     if (root != null)  
    //     { 
    //         inorderRec(root.left); 
    //        // System.out.print(root.key + " "); 
    //         inorderRec(root.right); 
    //     } 
    // } 
    // void treeins(int [] arr) 
    // { 
    //     for(int i = 0; i < arr.length; i++) 
    //     { 
    //         insert(arr[i]); 
    //     } 
          
    // } 
}
