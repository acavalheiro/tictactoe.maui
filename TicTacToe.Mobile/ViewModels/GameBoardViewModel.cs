// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameBoardViewModel.cs" company="The Virtual Forge">
// Copyright (c) 2023 All Rights Reserved
// </copyright>
// <summary>
// 
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TicTacToe.Mobile.ViewModels
{
    using System.Collections.ObjectModel;

    using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;

    using TicTacToe.Mobile.Models;

    public partial class GameBoardViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _gameStatus;
        private bool _playerTurn = false;

        private int _currentMoves = 0;
        public GameBoardViewModel()
        {
            
            this.SetupGameInfo();
        }

        public ObservableCollection<TicTacToeModel> Board { get; set; } = new ObservableCollection<TicTacToeModel>();

        private void SetupGameInfo()
        {
            this.Board.Clear();

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    this.Board.Add(new TicTacToeModel(x,y));
                }
                
            }
        }

        [RelayCommand]
        public void RestartGame()
        {
            this.GameStatus = string.Empty;
            this.SetupGameInfo();
        }

        [RelayCommand]
        public void SelectedItem(TicTacToeModel selectedItem)
        {

            if (selectedItem.Player.HasValue)
                return;

            selectedItem.SelectedText = this._playerTurn ? "X" : "0";
            selectedItem.Player = this._playerTurn;
            

            this._currentMoves++;


            if (this.CheckForWin(this._playerTurn))
            {
                this.GameStatus = $"Player {(this._playerTurn ? "X" : "0")} Wins";
            }

            this._playerTurn = !this._playerTurn;
        }

        private bool CheckForWin(bool player)
        {
            if (this._currentMoves < 5) return false;

            for (int i = 0; i < 3; i++)
            {
                var rows = this.Board.Where(item => item.X == i);

                if (rows.All(item => item.Player == player))
                    return true;

                rows = this.Board.Where(item => item.Y == i);

                if (rows.All(item => item.Player == player))
                    return true;
                
            }

            return (this.Board[0].Player == player && this.Board[4].Player == player && this.Board[8].Player == player) ||
                   (this.Board[2].Player == player && this.Board[4].Player == player && this.Board[6].Player == player);
        }

    }
}