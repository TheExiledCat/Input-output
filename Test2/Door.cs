using Godot;
using System;

public class Door : StaticBody2D
{
    [Export] Vector2 offset;
   void Open (){
       Position+=offset;
   }
}
