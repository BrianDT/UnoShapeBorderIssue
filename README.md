# UnoGeometryIssues
Replicates issues with WASM positioning

Issues are:
1) Under WASM, shape resizes when the shape stroke thickness changes.
In this sample this is done in visual state manage when responding to a pointer over.
The size change is recorded, and the number of size changes incremented.
Reported as issue #9254
Confirmed as resolved in Uno.UI 4.5.9
https://github.com/unoplatform/uno/issues/9254
