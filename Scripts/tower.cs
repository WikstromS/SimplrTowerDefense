using Godot;
using System;
using System.Diagnostics;

public partial class tower : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	public Node2D target;
	public RayCast2D ray_cast;
	

    // Get the gravity from the project settings to be synced with RigidBody nodes.
    // public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
    public override void _Ready()
    {
		
    }

    public override void _PhysicsProcess(double delta)
	{

	}

	public void OnBodyEntered(Node2D body)
	{
		target = body;
	}
}
