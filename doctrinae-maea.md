
# Doctrinae Maea

What I learned (on the Mac). I need to combine this information into my DoctrinaeMaea wikidpad (only available on Windows).

## Dev Tools

### Git

How to move a local repository into GitHub?

- http://stackoverflow.com/questions/11276364/after-using-git-to-locally-track-a-project-how-can-i-add-it-to-github
- file://move-local-git-to-github.pdf

### GitHub

How to preview the appearance of GitHub markdown files:

* https://github.com/joeyespo/grip
* file://grip-github-preview.pdf

### Sed

**The** guide to sed

* http://www.grymoire.com/Unix/Sed.html
* file://sed-an-introduction-and-tutorial.pdf 

## Software

### Languages

#### Clojure

What is the difference between vars and symbols?

- http://stackoverflow.com/questions/9113387/difference-between-symbols-and-vars-in-clojure
- file://clj-diff-betw-vars-and-symbols.pdf

What is the reason for Clojure distinguishing between vars and symbols?

- http://stackoverflow.com/questions/11662084/why-does-clojure-distinguish-between-symbols-and-vars
- file://clj-why-vars-and-symbols.pdf

#### IronPython

Using IronPython to access Microsoft SQL Server (using SMO)

- http://www.sqlservercentral.com/articles/IronPython/141610/
- file://using-ipy-with-sql-server.pdf

### Libs

#### ClojureScript

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

#### .NET

##### ASP.Net

Unit testing ASP.NET Web API (including adding a test project for an existing project)

* https://www.asp.net/web-api/overview/testing-and-debugging/unit-testing-with-aspnet-web-api
* file://unit-testing-asp-net-web-api.pdf
* http://www.peterprovost.org/blog/2012/06/16/unit-testing-asp-dot-net-web-api/
* file://unit-testing-web-api.pdf

##### Async/Await

Preventing deadlocks (by **not** capturing contexts)

- http://blog.stephencleary.com/2012/07/dont-block-on-async-code.html
- file://dont-block-on-async.pdf

##### NServiceBus

How to remove all MSMQ queues (except audit and error):
* https://www.ramonsmits.com/2016/03/31/delete-all-queues-except-error-and-audit.html
* file://delete-nsb-msmqs.pdf

Original post from previous question:

* http://suhinini.blogspot.nl/2009/11/delete-all-msmq-queues-at-some-pc-with.html
* file://delete-all-nsb-msmqs.pdf

## Security

Historical password lengths:

- http://security.stackexchange.com/questions/22721/password-length-limits-in-history-of-operating-systems-and-popular-web-sites
- file://historical-password-lengths.pdf

## Systems

### Windows

How to run a program as a different user?

* `C:\Windows\System32\runas.exe /netonly /user:nobrainer2\willk "C:\Program Files (x86)\Microsoft SQL Server\120\Tools\Binn\ManagementStudio\Ssms.exe"`

### Parallels

How to send F11 to Visual Studio Debug?

* http://kb.parallels.com/en/116172
* file://use_f11.pdf

Configure display settings on Retina

* http://blog.parallels.com/2015/08/18/how-to-configure-the-best-display-settings-for-parallels-desktop-on-a-retina-mac/
* file://configure_display_parallels.pdf
