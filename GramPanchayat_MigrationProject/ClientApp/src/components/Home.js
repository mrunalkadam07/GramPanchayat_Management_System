import React, { Component } from 'react';


export class Home extends Component {
  static displayName = Home.name;
  myStyle={
    backgroundImage: 
"url('0001.jpg')",
    height:'100vh',
    marginTop:'-70px',
    fontSize:'50px',
    backgroundSize: 'cover',
    backgroundRepeat: 'no-repeat',
};
  render() {
    return (
      <div style={this.myStyle}>
      </div>
    );
  }
}
