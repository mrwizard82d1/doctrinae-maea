# SAFE-dojo

I encountered a frustrating error trying to first run the SAFE-dojo using Node 18. It was characterized by the client presenting a 504 error trying to access the URL `/api/IDojoApi/GetDistance`. In addition to the client error, the log for the client presents the message

> client: [HPM] Error occurred while trying to proxy request /api/IDojoApi/GetDistance from localhost:8080 to http://localhost:8085 (ECONNREFUSED) (https://nodejs.org/api/errors.html#errors_common_system_errors)

I confirmed that the server was running and that it was listening on the appropriate port, 8085. After much "wailing and gnashing of teeth," I discovered three posts that indicate the problem results from a `nodejs` issue. In `node 16`, a dev server proxy would listen on port 8085 using **ipv4** but in Node 17 and above, it defaults to listening on **ipv6**. The fix / work-around is to change the `url` in `Server.fs` to `url "http://*:8085"` (listens on **all** interfaces).

Here are the three linked messages:

- [devServerProxy not working (ECONNREFUSED)](https://github.com/SAFE-Stack/SAFE-template/issues/518)
- [Listen on all interfaces including ipv6](https://github.com/SAFE-Stack/SAFE-template/pull/490)<br>
&nbsp;&nbsp; Fixed in `SAFE-Stack:master` but not, perhaps in SAFE-dojo
- [Upgrade webpack and npm deps](https://github.com/SAFE-Stack/SAFE-template/pull/485)
 