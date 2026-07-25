using Godot;
using System;

public enum SpaceType {
	Safe, Hole, Turtle
}

public partial class Main : Node {
	Space GameBoard = new Space[10];
	public override void _Ready() {
		for (int i = 0; i < GameBoard.GetLength(0); i++) {
			GameBoard[0] = new Space(true, SpaceType.Safe);
			GameBoard[1] = new Space(true, SpaceType.Safe);
			GameBoard[2] = new Space(false, SpaceType.Hole);
			GameBoard[3] = new Space(true, SpaceType.Safe);
			GameBoard[3] = new Space(true, SpaceType.Safe);
			GameBoard[5] = new Space(false, SpaceType.Hole);
			GameBoard[6] = new Space(true, SpaceType.Safe);
			GameBoard[7] = new Space(false, SpaceType.Hole);
			GameBoard[8] = new Space(true, SpaceType.Safe);
			GameBoard[9] = new Space(true, SpaceType.Safe);
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
}
