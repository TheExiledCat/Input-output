using Godot;
using System;

public class ShowAmount : Label
{
   
	public override void _Ready()
	{
	   Text=GetNode<Import>("../../../../Node2D").number.ToString();
		
	}

}
