// const path = require('path');
// const baseNetAppPath = path.join(__dirname, '\\src\\QuickStart.Core\\bin\\Debug\\netcoreapp2.0');

// console.log(__dirname);

// var asdf = __dirname.lastIndexOf('/');
// console.log(asdf);


var edgeDll = '/Consuum.EdgeJs/bin/Debug/netcoreapp2.0/Consuum.EdgeJs.dll'
var edgeProj = '/Consuum.EdgeJs/Consuum.EdgeJs.csproj'
var slnRoot = __dirname.substring(0, __dirname.lastIndexOf('/'));
console.log(slnRoot + edgeDll);

//process.env.EDGE_USE_CORECLR = 1;
//process.env.EDGE_APP_ROOT = baseNetAppPath;

var edge = require('edge-js');

var asdf = edge.func({
    assemblyFile: slnRoot + edgeDll,
    //typeName: 'Consuum.EdgeJs.Startup',
    //methodName: 'Invoke'
    //typeName: 'QuickStart.Core.LocalMethods',
    // methodName: 'GetAppDomainDirectory',
    references: [slnRoot + edgeDll]
});

asdf('JavaScript', function (error, result) {
    if (error) throw error;
    console.log(result);
    edgeresult = result;
  });

// var edge = require('edge');

// var hello = edge.func({
//     source: function () {/*
//         using System.Windows.Media.Imaging;
//         async (input) => 
//         { 
//             return ".NET welcomes " + input.ToString(); 
//         }
//     */},
//     references: ['c:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\WPF\\PresentationCore.dll']
// });

// hello('Node.js', function (error, result) {
//     if (error) throw error;
//     console.log(result);
// });