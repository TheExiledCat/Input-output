using Godot;
using System;

public class ShowAmount : TextEdit
{
   
    public override void _Ready()
    {
        Text=GetNode<Import>("../../../../Node2D").number.ToString();
        
    }

}
