using System;
namespace BlazorWASM.ViewModels
{
    public class CounterPageViewModel
    {
        public CounterPageViewModel()
        {
        }
        public int CurrentCount { get; set; }

        public void IncrementCount()
        {
            CurrentCount++;
        }
    }
}
