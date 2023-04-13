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

    public partial class GameBoardViewModel : ObservableObject
    {
        public GameBoardViewModel()
        {
            this.Board.Clear();
                
                
               this.Board.Add("1");
               this.Board.Add("1");
               this.Board.Add("1");
               this.Board.Add("2");
               this.Board.Add("2");
               this.Board.Add("2");
               this.Board.Add("3");
               this.Board.Add("3");
               this.Board.Add("3");

        }

        public ObservableCollection<string> Board { get; set; } = new ObservableCollection<string>
                                                                      {
                                                                          "1",
                                                                          "2",
                                                                          "3",
                                                                          "4",
                                                                          "5",
                                                                          "6",
                                                                          "7",
                                                                          "8",
                                                                          "9"
                                                                      };
    }
}