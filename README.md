# RiderDebuggerTest
RiderDebuggerTest

## DebuggerTest - Console

Comment/Uncomment given main method 
1. For Async debugger will breakpoint on ExceptionDispatchInfo.Throw
2. Non Async debugger will breakpoint on the source: Helper.MethodAsync, line 2

## DebuggerTest.UnitTests - Xunit
1. For Async debugger will not breakpoint
2. For non async debugger will breakpoint on the source Helper.MethodAsync, line 2

## DebuggerTest.WebApi - Asp .net core web api

Comment/Uncomment given Get method
1. For Async debugger will not breakpoint
2. For non async debugger will breakpoint on the source Helper.MethodAsync, line 2
