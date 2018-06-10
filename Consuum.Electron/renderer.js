// This file is required by the index.html file and will
// be executed in the renderer process for that window.
// All of the Node.js APIs are available in this process.

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