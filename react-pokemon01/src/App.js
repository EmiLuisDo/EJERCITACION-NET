import React from 'react';
import axios from 'axios';
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import GEN1 from "./Components/Generacion1"

function App() {


  return (
    <div>
      <Router>
        <Switch>
          <Route to="/gen1">
            <GEN1></GEN1>
          </Route>
          <Route to="/theRest">
          </Route>
        </Switch>
      </Router>
    </div>

  );
}

export default App;
