# Ionide file name casing bug reproduction

1) Make sure the project builds `dotnet build` should work as well as building in Visual Studio.
2) Open VSCode with Ionide extension installed.
3) Browse the `Program.fs` file
4) Mouse hover over the `MyFile.fs` declared function `personAsString`
5) Check the Output->Log (Extension host)

Something similar to this should be shown

```
[2022-10-26 11:45:42.488] [exthost] [error] [Ionide.Ionide-fsharp] provider FAILED
[2022-10-26 11:45:42.489] [exthost] [error] Error: No tooltip information
	at c:\Users\danie\.vscode\extensions\ionide.ionide-fsharp-7.2.1\fsharp.js:2:178257
	at c:\Users\danie\.vscode\extensions\ionide.ionide-fsharp-7.2.1\fsharp.js:2:178551
	at Immediate.<anonymous> (c:\Users\danie\.vscode\extensions\ionide.ionide-fsharp-7.2.1\fsharp.js:2:178913)
	at process.processImmediate (node:internal/timers:466:21)
```

The problem is that there is a mismatch in filename casing of `MyFile.fs` in the filesystem and in the project file `ionideCasingBug.fsproj`. 

## Workaround

Fix the casing in the fsproj file