An F# script illustrating some of the behavior of combining `Uri` instances and strings. (I'm not clear on the rules.)

One can, I believe copy the code into an F# script and send it (or pieces) to the F# interactive tool.

```
open System
let baseUriNoTrailingSlash = Uri("http://localtest.me")
let baseUriTrailingSlash = Uri("http://localtest.me/")

let withLeadingSlash = "/to-be/or-not-to-be"
let withNoLeadingSlash = "to-be/or-not-to-be"
let withLeadingAndTrailingSlash = "to-be/or-not-to-be/"

let combiner baseUri (stringUri:string) =
    Uri(baseUri, stringUri)
    
(combiner baseUriNoTrailingSlash withNoLeadingSlash)
// .ToString() returns "http://localtest.me/to-be/or-not-to-be"

(combiner baseUriTrailingSlash withLeadingSlash)
// .ToString() returns "http://localtest.me/to-be/or-not-to-be"

(combiner (combiner baseUriTrailingSlash withLeadingSlash) "that-is-the-question")
// .ToString() returns "http://localtest.me/to-be/that-is-the-question"

(combiner (combiner baseUriTrailingSlash withLeadingSlash) "/that-is-the-question")
// .ToString() returns "http://localtest.me/to-be/or-not-to-be/that-is-the-question"

(combiner (combiner baseUriTrailingSlash withLeadingAndTrailingSlash) "that-is-the-question")
// .ToString() returns "http://localtest.me/to-be/or-not-to-be/that-is-the-question"
```