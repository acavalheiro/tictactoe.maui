// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToeModel.cs" company="The Virtual Forge">
// Copyright (c) 2023 All Rights Reserved
// </copyright>
// <summary>
// 
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TicTacToe.Mobile.Models
{
    using CommunityToolkit.Mvvm.ComponentModel;

    /// <summary>
    /// The tic tac toe model.
    /// </summary>
    public partial class TicTacToeModel : ObservableObject
    {
        public TicTacToeModel(int x, int y)
        {
            this.X = x;
            this.Y = y;
            
        }
        public int X { get; set; }

        public int Y { get; set; }

        [ObservableProperty]
        private string _selectedText;

        public bool? Player { get; set; }
    }
}