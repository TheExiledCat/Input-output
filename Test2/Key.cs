using Godot;
using System;

public class Key : StaticBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
   
    public void Appear(){
        GetNode<Sprite>("Sprite").Texture=ResourceLoader.Load("res://art/key_activated.png") as Texture;
        GetNode<CollisionShape2D>("Collider").Disabled=false;
    }
    public void Dissapear(){
        QueueFree();

    }

}
