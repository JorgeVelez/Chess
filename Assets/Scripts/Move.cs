﻿
/*
 * Represents a chess move 
 */

public class Move{

	public bool isWhiteMove;
	public bool isPawnPromotion;
	public bool isEnPassantCapture;
	public bool isCastles;
	public bool isCapture;
	
	public int fromIndex;
	public int toIndex;

	public int enPassantPawnIndex;
	public int rookFromIndex;
	public int rookToIndex;

	public int movePieceType;
	public int capturePieceType;
	public int promotionPieceType;


	public Move(int _fromIndex, int _toIndex) {
		fromIndex = _fromIndex;
		toIndex = _toIndex;
	}
	
	public Move() {
	}

	/*
	public string algebraicMove {
		get {
			string promotionKey = "";
			if (isPawnPromotion) {
				promotionKey = (isWhiteMove)?"Q":"q";
			}
			return from.algebraic + to.algebraic + promotionKey;
		}
	}
	*/
}
