# Table of Contents

- [An overview of SynchronizationContext](https://msdn.microsoft.com/en-us/magazine/gg598924.aspx)
- [Task Asynchronous Programming Model](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/task-asynchronous-programming-model) contains a great diagram indicating the details of what happens when one uses `async` and `await` (about 1/4 of the way through the article).
- [Async/await doesn't create new threads](https://stackoverflow.com/questions/37419572/if-async-await-doesnt-create-any-additional-threads-then-how-does-it-make-appl) (Lot's of worthwhile details - and references to other good posts).
- [Combining URI Paths (and idiosyncrasies of the BCL `Uri` class)](https://stackoverflow.com/questions/372865/path-combine-for-urls)
- [The details of `Uri(Uri, string)`](https://docs.microsoft.com/en-us/dotnet/api/system.uri.-ctor?view=netframework-4.8#System_Uri__ctor_System_Uri_System_String_) - See the remarks section to understand the details (vagaries?) of how the `Uri` argument and the `string` argument are combined.
- [F# script illustrating `Uri(Uri, string)` behavior](./combine_uri_and_string)
