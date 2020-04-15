using Godot;
using System;

public class Door : StaticBody2D
{
    public Vector2 start;
    [Export] Vector2 offset;
    public override void _Ready(){
        start=Position;
    }
   void Open (){
       Position+=offset;
   }
}
