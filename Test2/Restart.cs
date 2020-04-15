using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;
public class Restart : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	
	// Called when the node enters the scene tree for the first time.
	[Export]public Array<NodePath> keys=new Array<NodePath>();
	[Export]Array<NodePath> activators=new Array<NodePath>();
	[Export]Array<NodePath> manas=new Array<NodePath>();
	[Export]Array<NodePath> Doors= new Array<NodePath>();
	public override void _Process(float delta)
	{
		if(Input.IsActionJustPressed("Restart")){
			retry();
		}
	}
	
	public void retry(){
			Player p=GetNode<Player>("../Player");
			int i=0;
			
			foreach(NodePath n in keys)
			{
				
				
				 GetNode<Key>(n).GetNode<Sprite>("Sprite").Texture= 	GetNode<Key>(n).spr;
				GetNode<Key>(n).GetNode<Sprite>("Sprite").Visible=true;
				 GetNode<Key>(n).GetNode<CollisionShape2D>("Collider").Disabled=true;
				 
			}
			foreach (NodePath n in activators)
			{
				GetNode<KeyActivator>(n).GetNode<Sprite>("Sprite").Visible=true;
				GetNode<KeyActivator>(n).GetNode<CollisionShape2D>("CollisionShape2D").Disabled=false;
			}
			foreach (NodePath n in manas)
			{
				GetNode<Mana>(n).GetNode<Sprite>("Sprite").Visible=true;
				GetNode<Mana>(n).GetNode<CollisionShape2D>("CollisionShape2D").Disabled=false;
			}
			foreach(NodePath n in Doors){
				GetNode<Door>(n).Position=GetNode<Door>(n).start;
			}
			p.positions.Clear();
			p.Position=p.start;
			p.keys=0;
			p.mana=0;
			
		//	GD.Print("reloading");
	}

}
