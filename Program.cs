using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::::::::::::Welcome To BinarySearch Tree Program:::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            int choice;

            {
                Console.WriteLine("**Press 0 For Exit***");
                Console.WriteLine("***1.Create Binary Search Tree By adding 56 and Then adding 30 and 70 ***");
                Console.WriteLine("***2.Create Binary Search Tree From Figure***");
                Console.WriteLine("***3.Ability To Search 63 In The Binary Tree***");
                Console.WriteLine("**Enter your choice***");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearchTree<int> binarytree = new BinarySearchTree<int>(56);
                        binarytree.Insert(30);
                        binarytree.Insert(70);
                        Console.WriteLine("**Binary search tree **(Inorder traversal/Ascending is )**");
                        binarytree.Display();
                        binarytree.Size();
                        break;
                    case 2:
                        CreateBinaryFighure<int> createBinary = new CreateBinaryFighure<int>(56);
                        createBinary.Insert(30);
                        createBinary.Insert(70);
                        createBinary.Insert(22);
                        createBinary.Insert(40);
                        createBinary.Insert(60);
                        createBinary.Insert(95);
                        createBinary.Insert(11);
                        createBinary.Insert(65);
                        createBinary.Insert(3);
                        createBinary.Insert(16);
                        createBinary.Insert(63);
                        createBinary.Insert(67);
                        Console.WriteLine();
                        Console.WriteLine("**Binary search tree **(Inorder traversal/Ascending is )**");
                        createBinary.Display();
                        createBinary.Size();
                        break;

                    case 3:
                        SearchBinary<int> objsearchBinary = new SearchBinary<int>(56);
                        objsearchBinary.Insert(30);
                        objsearchBinary.Insert(70);
                        objsearchBinary.Insert(22);
                        objsearchBinary.Insert(40);
                        objsearchBinary.Insert(60);
                        objsearchBinary.Insert(95);
                        objsearchBinary.Insert(11);
                        objsearchBinary.Insert(65);
                        objsearchBinary.Insert(3);
                        objsearchBinary.Insert(16);
                        objsearchBinary.Insert(63);
                        objsearchBinary.Insert(67);
                        Console.WriteLine("**Binary search tree **(Inorder traversal/Ascending is )**");
                        objsearchBinary.Display();
                        objsearchBinary.SearchTree( 63, objsearchBinary);
                        objsearchBinary.Size();
                        break;


                    default:
                        Console.WriteLine("*Enter Valid Number*");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
