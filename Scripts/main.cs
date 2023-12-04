using Godot;
using System;

public partial class main : Node2D
{

	[Export]
	public PackedScene enemy_scene {get;set;}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// GetNode<Timer>("EnemyTimer").Start();

		enemy enemy = enemy_scene.Instantiate<enemy>();
		var marker = GetNode<Marker2D>("EnemySpawnPoint");
		
		AddChild(enemy);
		enemy.Position = new Vector2(marker.Position.X, marker.Position.Y);

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnEnemyTimerTimeOut()
	{
		//new instance of enemy
		enemy enemy = enemy_scene.Instantiate<enemy>();

		AddChild(enemy);
	}
}
