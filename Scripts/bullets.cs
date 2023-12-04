using Godot;
using System;

public partial class bullets : Area2D
{
	Vector2 direction = Vector2.Right;
	float speed = 300f;

    public override void _PhysicsProcess(double delta)
    {
        Position += direction * speed * (float)delta;
    }

	public void OnScreenExited()
	{
		QueueFree();
	}
}
