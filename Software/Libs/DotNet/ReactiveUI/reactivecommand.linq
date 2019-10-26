<Query Kind="Statements">
  <NuGetReference>ReactiveUI</NuGetReference>
  <NuGetReference>ReactiveUI.WPF</NuGetReference>
  <NuGetReference>System.Reactive</NuGetReference>
  <NuGetReference>System.Reactive.Linq</NuGetReference>
  <Namespace>ReactiveUI</Namespace>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

Console.WriteLine("ReactiveCommand returning many values");
// A command that returns multiple values
var manyCommand = ReactiveCommand.CreateFromObservable<Unit, int>(
	_ => Observable.Concat((new List<int> {1, 2, 3}).ToObservable(), Observable.Empty<int>())
);

manyCommand.ThrownExceptions.Subscribe(ex => Console.WriteLine($"ThrownException={ex}"));

// Subscribing to execute **only** ticks the **last** value (and completion)
manyCommand.Execute(Unit.Default).Do(value => Console.WriteLine($"manyCommand.Execute() ticked {value}"),
								     ex => Console.WriteLine($"manyCommand.Execute() errored {ex}"),
								     () => Console.WriteLine("manyCommand.Execute() completed"))
							 .Subscribe();

// We can also subscribe to _all_ values that a command
// emits by using the `Subscribe()` method on the4
// ReactiveCommand itself.
manyCommand.Subscribe(value => Console.WriteLine($"manyCommand ticked {value}"),
				      ex => Console.WriteLine($"manyCommand errored {ex}"),
				      () => Console.WriteLine("manyCommand completed"));
				  
Console.WriteLine();
Console.WriteLine("ReactiveCommand throwing exception");

var errorCommand = ReactiveCommand.CreateFromObservable<Unit, int>(
	_ => Observable.Concat((new List<int> {1, 2, 3}).ToObservable(), Observable.Throw<int>(new ApplicationException("fubar")))
);

errorCommand.ThrownExceptions.Subscribe(ex => Console.WriteLine($"ThrownException={ex}"));

// Subscribing to execute **only** ticks the **last** value (and completion)
errorCommand.Execute(Unit.Default).Subscribe(value => Console.WriteLine($"errorCommand.Execute() ticked {value}"),
								             ex => Console.WriteLine($"errorCommand.Execute() errored {ex}"),
								      		 () => Console.WriteLine("errorCommand.Execute() completed"));

// We can also subscribe to _all_ values that a command
// emits by using the `Subscribe()` method on the4
// ReactiveCommand itself.
errorCommand.Subscribe(value => Console.WriteLine($"errorCommand ticked {value}"),
				       ex => Console.WriteLine($"errorCommand errored {ex}"),
				       () => Console.WriteLine("errorCommand completed"));