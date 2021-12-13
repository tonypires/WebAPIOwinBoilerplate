import logo from './logo.svg';
import './App.css';
import React from 'react';
import axios from 'axios';

class App extends React.Component {

  componentDidMount() {
    axios({
      method: 'post',
      url: 'http://localhost:8100/api/Default',
      header: {
        'content-type': 'application/json',
      },
      data: { 
        data:[
        {
          firstName: 'Hello'
        },
        {
          lastName: 'World'
        }]
      }
    });
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            Edit <code>src/App.js</code> and save to reload.
          </p>
          <a
            className="App-link"
            href="https://reactjs.org"
            target="_blank"
            rel="noopener noreferrer"
          >
            Learn React
          </a>
        </header>
      </div>
    );
  }
}

export default App;