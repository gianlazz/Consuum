import '../css/site.css';
// import 'bootstrap/dist/css/bootstrap.css';
// import 'jquery';
// import 'bootstrap';
import 'moonjs';

const app1 = new Moon({
    el: "#app1",
    data: {
      msg: "Hello Moon!"
    }
  });

  const app2 = new Moon({
    el: "#app2",
    data: {
      msg: "Hello Moon!"
    }
  });
  
  app2.set('msg', "Changed Message!");