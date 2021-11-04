﻿using System.Windows.Controls;

namespace WpfApp
{
    internal class TickData
    {
        public LiveChartsCore.SkiaSharpView.WPF.CartesianChart CandleStickChart { get; set; } = new();
        public LiveChartsCore.SkiaSharpView.WPF.CartesianChart LineChart { get; set; } = new();
        public StackPanel Container { get; set; } = new StackPanel();
        public TextBlock Name { get; set; } = new();
        public TextBlock Currency { get; set; } = new();
        public TextBlock ExchangeName { get; set; } = new();
        public TextBlock MarketState { get; set; } = new();
    };
}

