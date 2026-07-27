using Godot;
using System;

public enum SpaceType {
	Safe, Hole, Turtle
}

public partial class Main : Node {
	Space[] GameBoard = new Space[10];
	public override void _Ready() {
		GameBoard[0] = new Space(true, SpaceType.Safe);
		GameBoard[1] = new Space(true, SpaceType.Safe);
		GameBoard[2] = new Space(false, SpaceType.Hole);
		GameBoard[3] = new Space(true, SpaceType.Safe);
		GameBoard[4] = new Space(true, SpaceType.Safe);
		GameBoard[5] = new Space(false, SpaceType.Hole);
		GameBoard[6] = new Space(true, SpaceType.Safe);
		GameBoard[7] = new Space(false, SpaceType.Hole);
		GameBoard[8] = new Space(true, SpaceType.Safe);
		GameBoard[9] = new Space(true, SpaceType.Safe);
		for (int i = 0; i < GameBoard.Length; i++) {
			GameBoard[i].Position = new Vector2(i * 32, 0);
			AddChild(GameBoard[i]);
		}
	}

	public override void _Process(double delta) {
	}
}

public partial class Space : Area2D {
	public bool IsSafe {get; set; } = false;
	public SpaceType Type {get; set; } = SpaceType.Safe;
	public Space(bool isSafe, SpaceType type) {
		IsSafe = isSafe;
		Type = type;
	}

	public override void _Ready() {
		CollisionShape2D spaceShape = new CollisionShape2D();
		spaceShape.Shape = new CapsuleShape2D();
		AddChild(spaceShape);

		Sprite2D sprite = new Sprite2D();
		sprite.Texture = GD.Load<Texture2D>("res://playerGrey_up1.png");
		AddChild(sprite);
	}
}
