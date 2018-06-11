//var edge = require('electron-edge-js');
var edge = require('edge-js');

var helloWorld = edge.func(function () {/*
  async (input) => { 
      return ".NET Welcomes " + input.ToString(); 
  }
*/});

var edgeresult;

helloWorld('JavaScript', function (error, result) {
  if (error) throw error;
  console.log(result);
  edgeresult = result;
});

var path = '\\Consuum\\Consuum.EdgeJs\\bin\\Debug\\netcoreapp2.0\\'
var clrMethod = edge.func({
    assemblyFile: 'Consuum.EdgeJs.dll',
    
// If you don't specify typeName, a type name is constructed by 
// assuming the class called Startup in the namespace equal to the 
// assembly file name (without the .dll). 
// In the example above, if typeName was not specified, 
// it would default to My.Edge.Samples.Startup.   
    //typeName: 'Samples.FooBar.MyType',

// If you don't specify methodName, Invoke is assumed.    
    //methodName: 'MyMethod' // This must be Func<object,Task<object>>
});

clrMethod('JavaScript', function (error, result) {
    if (error) throw error;
    console.log(result);
    //edgeresult = result;
  });

//var clrMethod = edge.func('My.Edge.Samples.dll');