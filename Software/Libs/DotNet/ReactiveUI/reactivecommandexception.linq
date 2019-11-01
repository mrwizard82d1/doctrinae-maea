<Query Kind="Statements">
  <NuGetReference>ReactiveUI</NuGetReference>
  <NuGetReference>ReactiveUI.WPF</NuGetReference>
  <NuGetReference>System.Reactive</NuGetReference>
  <NuGetReference>System.Reactive.Linq</NuGetReference>
  <Namespace>ReactiveUI</Namespace>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

Console.WriteLine("ReactiveCommand throwing exception");

var errorCommand = ReactiveCommand.CreateFromObservable<Unit, int>(
	_ => Observable.Concat((new List<int> {1, 2, 3}).ToObservable(), Observable.Throw<int>(new ApplicationException("fubar")))
);

// Run this script with this line uncommented and the thrown exception is "caught" in 
// **both** `ThrownExceptions` and `errorCommand.Execute.Subscribe(..., ex => ...)`.
// Comment out this line, run this script and, even though I handle the error in the
// `Subscribe` overload, the exception is **thrown**.
errorCommand.ThrownExceptions.Subscribe(ex => Console.WriteLine($"ThrownException={ex}"));

// Subscribing to execute **only** ticks the **last** value (and completion)
errorCommand.Execute(Unit.Default).Subscribe(value => Console.WriteLine($"errorCommand.Execute() ticked {value}"),
								             ex => Console.WriteLine($"errorCommand.Execute() errored {ex}"),
								      		 () => Console.WriteLine("errorCommand.Execute() completed"));