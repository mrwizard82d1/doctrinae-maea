# Doctrinae Maea

What I learned (on the Mac). I need to combine this information into my DoctrinaeMaea wikidpad (only available on Windows).

## Design

### Algorithms

#### Search

Comparison of ternary, binary and Fibonacci search:

* http://www.cs.utsa.edu/~wagner/CS3343/binsearchtest/search.html
* file://compare-binary-ternary-fibonacci-search.pdf

## Dev Tools

### Automating web requests

Here's my process for automating (RESTful?) web requests

* Open Chrome development tools for app
* Navigate to "Network" tab
* Open the context menu for the request
* Select "Copy > As curs (bash)"
* Paste curl script into shell script
* Navigate to https://curl.trillworks.com/#python in another browser
* Paste curl script into "curl command" text box
* Python script is automatically generated in the "Python requests" text box
* Copy text from "Python requests" box into Python file
* Change language to "Node.js"
* Copy text from "Node.js" text box into JavaScript file

### Docker

(Powershell) script to completely uninstall Docker on Windows (10):

- https://success.docker.com/article/how-to-completely-remove-docker-in-windows-10
- file://clean-docker-windows-10.pdf

### Git

How to move a local repository into GitHub?

- http://stackoverflow.com/questions/11276364/after-using-git-to-locally-track-a-project-how-can-i-add-it-to-github
- file://move-local-git-to-github.pdf

How to use `git bisect`:

- http://www.marclittlemore.com/posts/how-to-find-bugs-using-git-bisect-with-this-easy-guide/
- file://h2-use-git-bisect.pdf

How to clean up stale branches:

- http://railsware.com/blog/2014/08/11/git-housekeeping-tutorial-clean-up-outdated-branches-in-local-and-remote-repositories/ 
- file://git-clean-outdated.pdf

Explanation of ours and theirs in merge and rebase:

- https://stackoverflow.com/questions/25576415/what-is-the-precise-meaning-of-ours-and-theirs-in-git
- file://git-merge-rebase-ours-theirs.pdf

Merging specific files only from one branch to another:

- http://jasonrudolph.com/blog/2009/02/25/git-tip-how-to-merge-specific-files-from-another-branch/
- file://merge-specific-files-between-branches.pdf

### GitHub

How to preview the appearance of GitHub markdown files:

* https://github.com/joeyespo/grip
* file://grip-github-preview.pdf

### JetBrains

#### WebStorm

If .eslint rules specify windows line endings, WebStorm *always* report an error:

- https://youtrack.jetbrains.com/issue/WEB-25487
- file://webstorm-eslint-always-crlf-error.pdf

Electron in WebStorm:

- https://blog.jetbrains.com/webstorm/2016/05/getting-started-with-electron-in-webstorm/
- file://electron-in-webstorm.pdf

Debugging Electron Apps:

- https://blog.jetbrains.com/webstorm/2016/05/getting-started-with-electron-in-webstorm/
- file://electron-in-webstorm.pdf

### Postman

Restoring a maximized Postman window that one cannot restore. (Search
for "reset the app's window settings manually"):

- https://github.com/postmanlabs/postman-app-support/issues/2992
- file://postman-window-issues.pdf

### Sed

**The** guide to sed

* http://www.grymoire.com/Unix/Sed.html
* file://sed-an-introduction-and-tutorial.pdf 

### Selenium

The Selenium API documentation:

- https://stackoverflow.com/questions/5644868/webdriver-selenium-2-api-documentation
- file://selenium-api-docs.pdf

### Tmux

How to use tmux in Cmder on windows (using cywin)

- https://github.com/cmderdev/cmder/issues/453 
- file://tmux-in-cygwin-cmder.pdf

Examples of standard pane layouts:

- http://lgfang.github.io/mynotes/utils/tmux-intro.html#sec-5-5
- file://tmux-std-pane-layouts.pdf

Copying tmux buffers

- https://awhan.wordpress.com/2010/06/20/copy-paste-in-tmux/
- file://copy-paste-in-tmux.pdf

### Vim

Replace multiple whitespace with single (throughout file):

- https://stackoverflow.com/questions/3860532/vim-regex-replace-multiple-consecutive-spaces-with-only-one-space
- file://vim-many-ws-to-one.pdf

### Webpack

A great explanation of `webpack` (2):

* https://blog.madewithenvy.com/getting-started-with-webpack-2-ed2b86c68783
* file://webpack-2-explanation.pdf

## Software

### Languages

#### Clojure

What is the difference between vars and symbols?

- http://stackoverflow.com/questions/9113387/difference-between-symbols-and-vars-in-clojure
- file://clj-diff-betw-vars-and-symbols.pdf

What is the reason for Clojure distinguishing between vars and symbols?

- http://stackoverflow.com/questions/11662084/why-does-clojure-distinguish-between-symbols-and-vars
- file://clj-why-vars-and-symbols.pdf

Beating the averages: A contrarian take on language selection

- http://www.paulgraham.com/avg.html
- file://beating-the-averages.html

##### Elixir

Enable shell history in iex

- https://til.hashrocket.com/posts/is9yfvhdnp-enable-history-in-iex-through-erlang-otp-20- 
- file://enable-iex-history.pdf
- The answer: `export ERL_AFLAGS="-kernel shell_history enabled"`

##### Fsharp

Building a web app with a REST API using MongoDB:

- https://medium.com/@leocavalcante/rest-api-with-mongodb-and-f-on-net-core-605a2336f264
- file://rest-api-mongo-db-fsharp.pdf

Overview of F# asynchronous workflows:

- https://fsharpforfunandprofit.com/posts/concurrency-async-and-parallel/
- file://async-workflows-overview


##### Leiningen

Use the `localrepo` plugin to create "fake," local repository entries

- https://github.com/kumarshantanu/lein-localrepo

#### IronPython

Using IronPython to access Microsoft SQL Server (using SMO)

- http://www.sqlservercentral.com/articles/IronPython/141610/
- file://using-ipy-with-sql-server.pdf

#### JavaScript

How to implement enumerations:

* https://stijndewitt.com/2014/01/26/enums-in-javascript/
* file://enums-in-javascript.pdf

#### Python

##### subprocess

Explanation of different options for interacting with child processes:

* http://stackoverflow.com/questions/12600892/how-do-i-get-all-of-the-output-from-my-exe-using-subprocess-and-popen
* file://python-subprocess-output.pdf

Performance of 'subprocess' options:

* http://stackoverflow.com/questions/25333537/performance-of-subprocess-check-output-vs-subprocess-call
* file://python-subprocess-performance.pdf

#### Ruby

##### Rbenv

Simple steps to installing `rbenv`:

- http://www.codementor.io/akabiru/3-steps-set-up-ruby-environment-macos-6mavm7jrl
- file://rbenv-macos-3-steps.pdf

### Libs

#### ClojureScript

JavaScript "equivalents":

* https://kanaka.github.io/clojurescript/web/synonym.html
* file://js-cljs-equivalents.pdf

ClojureScript on Node with Channels:

- https://keminglabs.com/blog/tech-of-clear-commit/
- file://cljs-node-and-channels.pdf

TDD in ClojureScript:

- https://8thlight.com/blog/eric-smith/2016/10/05/a-testable-clojurescript-setup.html
- file://tdd-in-cljs.pdf

##### Boot

A starter kit to build ClojureScript applications using Node.js

- https://specious.github.io/blog/2016/12/07/Starting-a-NodeJS-app-with-ClojureScript-and-Boot/
- file://cljs-nodejs-boot-starter.pdf

##### Om

Eliminating the "Each child in an array or iterator should have a unique key" warning:

- http://www.thesoftwaresimpleton.com/blog/2014/11/06/react-key/ 
- file://om-unique-keys.pdf

##### Reagent

How to eliminate the warning: "Every element in a seq should have a unique :key."

- http://stackoverflow.com/questions/33446913/reagent-react-clojurescript-warning-every-element-in-a-seq-should-have-a-unique
- file://every-elem-in-a-seq-warning.pdf

How to address the warning: "Reactive deref not supported in seq..."
- https://github.com/reagent-project/reagent/issues/18
- file://reactive-deref-not-supported-in-seq.pdf

#### JavaScript

##### AngularJS

How to query the scope for angular elements:

* http://stackoverflow.com/questions/36999739/what-does-0-double-equals-dollar-zero-mean-in-chrome-developer-tools
* file://chrome-dev-tools-currently-selected-element.pdf

Unit testing Angular components with ngMock:

* http://www.bradoncode.com/blog/2015/06/05/ngmock-fundamentals-testing-controllers/
* file://angular-unit-testing-and-mocks.pdf
* https://www.sitepoint.com/mocking-dependencies-angularjs-tests/
* file://mock-dependencies-ngjs.pdf

Simple explanation of the AngularJS injector:

* http://odetocode.com/blogs/scott/archive/2014/01/13/meet-the-angularjs-injector.aspx
* file://meet-ngjs-injector.pdf

A more complicated explanation of AngularJS dependency injection:

* https://github.com/angular/angular.js/wiki/Understanding-Dependency-Injection
* file://understanding-ng-di.pdf

##### Immutable.js

An understandable, general discussion of immutable data structures using `Immutable.js`

* https://auth0.com/blog/intro-to-immutable-js/
* file://intro-to-immutable.pdf

A great tutorial: first create a React app then transform it to a Redux app using Immutable:

- https://www.sitepoint.com/how-to-build-a-todo-app-using-react-redux-and-immutable-js/
- file://react-redux-immutable.js

##### Jest

Mocking window properties in Jest:

- https://stackoverflow.com/questions/40449434/mocking-globals-in-jest 
- file://mocking-globals-in-jest.pdf

##### Knockout.js

Getting the value of an observable:

- https://stackoverflow.com/questions/36223873/is-there-anyway-to-inspect-knockout-observables-using-chrome-debugger
- file://ko-observable-value.pdf


##### Node.js

Running node inside `rlwrap`:

- https://nodejs.org/api/repl.html
- save://file:node-repl.pdf

How to list globally installed packages:

* https://ponderingdeveloper.com/2013/09/03/listing-globally-installed-npm-packages-and-version/
* file://list-global-npm-packages.pdf

##### React

A detailed, tongue-in-cheek explanation of React Life Cycle methods

- https://engineering.musefind.com/react-lifecycle-methods-how-and-when-to-use-them-2111a1b692b1
- file://react-lifecycle-how-and-why.pdf

React *elements* and *components*

- https://tylermcginnis.com/react-elements-vs-react-components/
- file://react-elements-v-components.pdf

A more pendantic take on elements and components:

- https://facebook.github.io/react/blog/2015/12/18/react-components-elements-and-instances.html
- file://react-components-elements-instances.pdf

An "architecture" for unit testing connected components:

- https://medium.com/@caljrimmer/simple-react-redux-testing-cd579d4c2103
- file://react-redux-testing.pdf

Resources for testing React-Redux:

- https://github.com/markerikson/react-redux-links/blob/master/react-redux-testing.md 
- file://react-redux-testing-resources.pdf

Mocking `fetch` using `jest`:

- https://medium.com/@ferrannp/unit-testing-with-jest-redux-async-actions-fetch-9054ca28cdcd
- file://mock-fetch-using-jest.pdf

Designing a React UI:

- https://facebook.github.io/react/docs/thinking-in-react.html
- file://thinking-in-react.pdf

Optimizing React (Avoiding Reconciliation)

- https://facebook.github.io/react/docs/optimizing-performance.html
- file://optimize-react-performance.pdf

- https://facebook.github.io/react/docs/optimizing-performance.html#avoid-reconciliation

React routing tutorial:

- https://medium.com/@pshrmn/a-simple-react-router-v4-tutorial-7f23ff27adf;
- file://react-router-v4-tutorial.pdf

A *better* example of React router version 4:

- https://gist.github.com/siakaramalegos/df4620c52e829f6107c75d5c3f0ad7f5
- file://react-router-v4-gist.js

A FAQ on React state:

- https://medium.com/react-ecosystem/how-to-handle-state-in-react-6f2d3cd73a0c
- file://state-in-react.pdf

Changing React state from input element

- https://thinkster.io/tutorials/react-change-state-from-input
- file://change-react-state-from-input.pdf

A step-by-step guide to building react-redux apps

- https://medium.com/@rajaraodv/step-by-step-guide-to-building-react-redux-apps-using-mocks-48ca0f47f9a 
- file://step-by-step-react-redux.pdf

#### .NET

##### ASP.Net

Unit testing ASP.NET Web API (including adding a test project for an existing project)

* https://www.asp.net/web-api/overview/testing-and-debugging/unit-testing-with-aspnet-web-api
* file://unit-testing-asp-net-web-api.pdf
* http://www.peterprovost.org/blog/2012/06/16/unit-testing-asp-dot-net-web-api/
* file://unit-testing-web-api.pdf

Creating "fake" requests / responses:

* http://stackoverflow.com/questions/18098585/moq-mocking-mvc-controllers-response-cookies-clear/18101855#18101855
* file://moc-mvc-controller-response-cookies.pdf

The meaning of various Uri properties:

- https://www.cambiaresearch.com/articles/53/how-do-i-get-paths-and-url-fragments-from-the-httprequest-object
- file://uri-paths-and-fragments.pdf

##### Async/Await

Preventing deadlocks (by **not** capturing contexts)

- http://blog.stephencleary.com/2012/07/dont-block-on-async-code.html
- file://dont-block-on-async.pdf

##### Metrics (Java but ported to .NET)

- http://codahale.com/codeconf-2011-04-09-metrics-metrics-everywhere.pdf 

##### Moq

Mocking `async` functions:

- http://stackoverflow.com/questions/21253523/setup-async-task-callback-in-moq-framework
- file://mock_async_functions.pdf

##### NServiceBus

How to remove all MSMQ queues (except audit and error):
* https://www.ramonsmits.com/2016/03/31/delete-all-queues-except-error-and-audit.html
* file://delete-nsb-msmqs.pdf

Original post from previous question:

* http://suhinini.blogspot.nl/2009/11/delete-all-msmq-queues-at-some-pc-with.html
* file://delete-all-nsb-msmqs.pdf

##### Rx.NET

The difference between ObserveOn and SubscribeOn: where is the work done

- https://stackoverflow.com/questions/20451939/observeon-and-subscribeon-where-the-work-is-being-done
- file://observe-on-subscribe-on-csharp.pdf

##### TickSpec

[TickSpec](./Software/Libs/DotNet/TickSpec.md)

#### Shells

##### Babun

Error 127 running tmux (caused by upgrade to 64-bit Cygwin?)

* https://github.com/babun/babun/issues/720
* file://tmux-not-working-127.pdf

##### Bash

Usage of positional paramenters:

* http://stackoverflow.com/questions/12314451/accessing-bash-command-line-args-vs (Search for "overview table")
* file://bash-positional-args.pdf
* http://wiki.bash-hackers.org/scripting/posparams

##### Powershell

Word count equivalent:

* https://blogs.technet.microsoft.com/heyscriptingguy/2011/10/09/use-a-powershell-cmdlet-to-count-files-words-and-lines/
* file://ps1-print-dll-versions.pdf

Recursively search directories for dll's reporting their version numbers

* http://stackoverflow.com/questions/3267009/get-file-version-and-assembly-version-of-dll-files-in-the-current-directory-and
* file://ps1-word-count.pdf

## Security

Historical password lengths:

- http://security.stackexchange.com/questions/22721/password-length-limits-in-history-of-operating-systems-and-popular-web-sites
- file://historical-password-lengths.pdf

### .NET security classes

[An introduction to .NET Security](./dotnet-security/dotnet-security.md)

## Software engineering

### Unit testing

Hard evidence of unit testing ROI?

* http://stackoverflow.com/questions/237000/is-there-hard-evidence-of-the-roi-of-unit-testing
* file://roi-unit-testing.pdf

Williams study on unit testing:

* http://collaboration.csc.ncsu.edu/laurie/Papers/TDDpaperv8.pdf
* file://tdd-costs-williams.pdf

Microsoft study on unit testing:

* http://research.microsoft.com/en-us/groups/ese/nagappan_tdd.pdf
* file://microsoft-tdd-costs.pdf

### NoSQL database comparison

- http://kkovacs.eu/cassandra-vs-mongodb-vs-couchdb-vs-redis 
- file://nosql-db-comparison.pdf

### Performance

Memory usage of JavaScript UI libraries and frameworks:

* https://auth0.com/blog/more-benchmarks-virtual-dom-vs-angular-12-vs-mithril-js-vs-the-rest/
* file://js-ui-memory-benchmarks.pdf

And a quick link to the results: 

* https://auth0.com/blog/more-benchmarks-virtual-dom-vs-angular-12-vs-mithril-js-vs-the-rest/#results-link

### Usability

Error messages on web pages:

* https://conversionxl.com/blog/error-messages/
* file://web-page-error-message-mistakes.pdf

Notifications (toast):

* https://ux.stackexchange.com/questions/11203/how-long-should-a-temporary-notification-toast-appear
* file://how-long-notifications.pdf

## Systems

### Windows

How to run a program as a different user?

* `C:\Windows\System32\runas.exe /netonly /user:nobrainer2\willk "C:\Program Files (x86)\Microsoft SQL Server\120\Tools\Binn\ManagementStudio\Ssms.exe"`

Uninstalling stubborn applications;

- https://www.mssqltips.com/sqlservertip/4050/cleanly-uninstalling-stubborn-sql-server-components/
- file://cleanly-uninstall-stubborn-components.pdf

### Parallels

How to send F11 to Visual Studio Debug?

* http://kb.parallels.com/en/116172
* file://use_f11.pdf

Configure display settings on Retina

* http://blog.parallels.com/2015/08/18/how-to-configure-the-best-display-settings-for-parallels-desktop-on-a-retina-mac/
* file://configure_display_parallels.pdf

### Mac OS X

Quickly show hidden files in Finder:

- https://osxdaily.com/2011/03/01/show-hidden-files-in-mac-os-x-dialog-boxes-with-commandshiftperiod/ 
- file://hidden-files-in-finder.pdf

