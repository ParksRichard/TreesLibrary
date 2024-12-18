using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace TreesLibrary
{
    internal class Program
    {
        //you are given the root of a binary search tree and the integer val
        //find the node in the BST that the nodes value equals val
        //and return the subtree rooted with that ndoe, if not, then null

        //define and insert val integer
        //ensure that type of travesal runs through whole tree? Pre order?
        //run a for a or while loop to search for integer val then return 
            //if statement if null

        static void Main(string[] args)
        {

            //BinaryTree<string> tree = GetTree();
            //BinaryTreeNode<string>? node = tree.Root;
            //while (node != null)
            //{
            //    if (node.Left != null && node.Right != null)
            //    {
            //        Console.WriteLine(node.Data);
            //        node = Console.ReadKey(true).Key switch
            //        {
            //            ConsoleKey.Y => node.Left,
            //            ConsoleKey.N => node.Right,
            //            _ => node
                        
            //        };
            //        Console.WriteLine("");
            //    }
            //    else
            //    {
            //        Console.WriteLine(node.Data);
            //        node = null;
            //    }
            //}
            
            BinaryTree<string> GetTree()
            {
                BinaryTree<string> tree = new();

                tree.Root = new BinaryTreeNode<string>()
                {
                    Data = "Do you have an experience in app development ? ",

                    Children =
                [
                new BinaryTreeNode<string>()
{
                Data = "Have you worked as a developer for 5 + years ? ",

                Children =
                [
                new() { Data = "Apply as a senior developer" },

                new() { Data = "Apply as a middle developer" }
                ]
                },
                new BinaryTreeNode<string>()
                {
                Data = "Have you completed a university?",
                Children =
                [
                new() { Data = "Apply as a junior developer" },

                new BinaryTreeNode<string>()
                {
                Data = "Will you find some time during the semester?",

                Children =
                [
                new() { Data = "Apply for long-time internship" },

                //add MSSA related question to expand tree beyond bottom right question
                
                new BinaryTreeNode<string>()
                {
                Data = "Have you completed the MSSA program?",

                    Children =
                    [
                        new() { Data = "Congrats, high five." },
                        new() { Data = "Better get a summer job." }
                    ]
                }
                //this does all look kinda funny
                ]
                }
                ]
                }
                ]
                };
                tree.Count = 11;

                return tree;
            }

        }


    }



}
