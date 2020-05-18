using System;
using BlazorWASM.ViewModels;

namespace BlazorWASM.Pages
{
    public partial class CounterPage
    {
        CounterPageViewModel ViewModel { get; set; } = new CounterPageViewModel();
    }
}
