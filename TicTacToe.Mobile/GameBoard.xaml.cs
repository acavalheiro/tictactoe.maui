// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameBoard.xaml.cs" company="The Virtual Forge">
// Copyright (c) 2023 All Rights Reserved
// </copyright>
// <summary>
// 
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TicTacToe.Mobile;

using TicTacToe.Mobile.ViewModels;

public partial class GameBoard : ContentPage
{
    public GameBoard()
    {
        this.InitializeComponent();
        this.BindingContext = new GameBoardViewModel();
    }

    private void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
    {
        Console.WriteLine("bla");
    }
}