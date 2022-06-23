using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SIGameMaker.Models;

namespace SIGameMaker.Views.Components;

public partial class RoundsHierarchy : UserControl
{
    public static readonly DependencyProperty RoundsProperty = DependencyProperty.Register(
        nameof(Rounds),
        typeof(IEnumerable<Round>),
        typeof(RoundsHierarchy)
    );

    public IEnumerable<Round>? Rounds
    {
        get => (IEnumerable<Round>?)GetValue(RoundsProperty);
        set => SetValue(RoundsProperty, value);
    }
    public RoundsHierarchy() => InitializeComponent();
}