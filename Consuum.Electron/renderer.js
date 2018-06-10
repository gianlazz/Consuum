// This file is required by the index.html file and will
// be executed in the renderer process for that window.
// All of the Node.js APIs are available in this process.

var edge = require('electron-edge-js');
//var edge = require('edge-js');

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

// Production Build
const Moon = require("moonjs");

// Development Build
//const Moon = require("moonjs/dist/moon.js");

new Moon({
    el: "#app",
    data: {
      msg: "Hello Moon!"
    }
  });

  const app3 = new Moon({
    el: "#app3",
    data: {
      msg: "Hello Moon!"
    },
    methods: {
      changeMessage: function(msg) {
        this.set('msg', msg);
      }
    }
  });
  
  app3.callMethod('changeMessage', [edgeresult]);