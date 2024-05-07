using System;
using System.Collections.Generic;
/*
public class TreeNode
{
    public int Value { get; set; }
    public List<TreeNode> Children { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Children = new List<TreeNode>();
    }

    public void AddChild(TreeNode child)
    {
        Children.Add(child);
    }

    public void PrintValues()
    {
        Console.WriteLine($"Node value: {Value}");
        foreach (var child in Children)
        {
            child.PrintValuesRecursive();
        }
    }

    private void PrintValuesRecursive()
    {
        Console.WriteLine($"Child value: {Value}");
        foreach (var child in Children)
        {
            child.PrintValuesRecursive();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем узлы дерева
        TreeNode root = new TreeNode(1);
        TreeNode node2 = new TreeNode(2);
        TreeNode node3 = new TreeNode(3);
        TreeNode node4 = new TreeNode(4);
        TreeNode node5 = new TreeNode(5);
        TreeNode node6 = new TreeNode(6);

        // Добавляем потомков к узлам
        root.AddChild(node2);
        root.AddChild(node3);
        node2.AddChild(node4);
        node2.AddChild(node5);
        node3.AddChild(node6);

        // Выводим значения детей узлов
        root.PrintValues();
    }
}
*/


namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree dad = new Tree(1);
            Tree child1 = new Tree(2);
            Tree child2 = new Tree(3);
            Tree grandchild11 = new Tree(4);
            Tree grandchild21 = new Tree(5);
            Tree grandchild12 = new Tree(6);
            Tree doubleGrandchild = new Tree(7);

            dad.addChild(child1);
            dad.addChild(child2);

            child1.addChild(grandchild11);
            child1.addChild(grandchild21);

            child2.addChild(grandchild12);

            grandchild21.addChild(doubleGrandchild);

            dad.Read();
        }
    }

}
