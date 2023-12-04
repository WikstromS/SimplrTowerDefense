using Godot;
using System;
using System.Diagnostics;

public partial class enemy : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Debug.WriteLine("HEP");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

    public override void _PhysicsProcess(double delta)
    {
        Position += new Vector2(-2, 0);
    }
}
